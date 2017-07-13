using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Web.Services;
using System.Web.Services.Description;
using System.Xml.Serialization;
using System.Reflection;


namespace WsdlReader
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        #region Dynamic Invocation WSDL file
        private void DynamicInvocation()
        {
            try
            {
                messageTextBox.Text += "Generating WSDL \r\n";
                progressBar1.PerformStep();

                Uri uri = new Uri(textBox1.Text);

                messageTextBox.Text += "Generating WSDL \r\n"; 
                progressBar1.PerformStep();

                WebRequest webRequest = WebRequest.Create(uri);
                System.IO.Stream requestStream = webRequest.GetResponse().GetResponseStream();
                // Get a WSDL file describing a service
                ServiceDescription sd = ServiceDescription.Read(requestStream);
                string sdName = sd.Services[0].Name;
                // Add in tree view
                treeWsdl.Nodes.Add(sdName);

                messageTextBox.Text += "Generating Proxy \r\n";
                progressBar1.PerformStep();

                // Initialize a service description servImport
                ServiceDescriptionImporter servImport = new ServiceDescriptionImporter();
                servImport.AddServiceDescription(sd, String.Empty, String.Empty);
                servImport.ProtocolName = "Soap";
                servImport.CodeGenerationOptions = CodeGenerationOptions.GenerateProperties;

                messageTextBox.Text += "Generating assembly  \r\n";
                progressBar1.PerformStep();

                CodeNamespace nameSpace = new CodeNamespace();
                CodeCompileUnit codeCompileUnit = new CodeCompileUnit();
                codeCompileUnit.Namespaces.Add(nameSpace);
                // Set Warnings
                ServiceDescriptionImportWarnings warnings = servImport.Import(nameSpace, codeCompileUnit);

                if (warnings == 0)
                {
                    StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.CurrentCulture);
                    Microsoft.CSharp.CSharpCodeProvider prov = new Microsoft.CSharp.CSharpCodeProvider();
                    prov.GenerateCodeFromNamespace(nameSpace, stringWriter, new CodeGeneratorOptions());

                    messageTextBox.Text += "Compiling assembly \r\n";
                    progressBar1.PerformStep();

                    // Compile the assembly with the appropriate references
                    string[] assemblyReferences = new string[2] { "System.Web.Services.dll", "System.Xml.dll" };
                    CompilerParameters param = new CompilerParameters(assemblyReferences);
                    param.GenerateExecutable = false;
                    param.GenerateInMemory = true;
                    param.TreatWarningsAsErrors = false;
                    param.WarningLevel = 4;

                    CompilerResults results = new CompilerResults(new TempFileCollection());
                    results = prov.CompileAssemblyFromDom(param, codeCompileUnit);
                    Assembly assembly = results.CompiledAssembly;
                    service = assembly.GetType(sdName);

                    messageTextBox.Text += "Get Methods of Wsdl \r\n";
                    progressBar1.PerformStep();

                    methodInfo = service.GetMethods();
                    foreach (MethodInfo t in methodInfo)
                    {
                        if (t.Name == "Discover")
                            break;


                        treeWsdl.Nodes[0].Nodes.Add(t.Name);
                    }

                    treeWsdl.Nodes[0].Expand();

                    messageTextBox.Text += "Now ready to invoke \r\n ";
                    progressBar1.PerformStep();
                    this.tabControl1.SelectedTab = this.tabPage1;

                }
                else
                    messageTextBox.Text += warnings;
            }
            catch (Exception ex)
            {
                messageTextBox.Text += "\r\n"+ex.Message +"\r\n\r\n"+ ex.ToString(); ;
                progressBar1.Value = 70;
            }
        }

        #endregion

        #region Event controls

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WSDL files |*.wsdl|All files|*.*";
            DialogResult dialogresult = ofd.ShowDialog();

            if (dialogresult == DialogResult.OK)
                textBox1.Text = ofd.FileName;

            if (textBox1.Text.Length != 0)
            {
                button2_Click(Browse, new EventArgs());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeWsdl.Nodes.Clear();
            treeParameters.Nodes.Clear();
            propertyGrid1.SelectedObject = null;
            messageTextBox.Text = "";
            treeOutput.Nodes.Clear();

            this.tabControl1.SelectedTab = this.tabPage2;
            DynamicInvocation();
        }
 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0)
                button2.Enabled = true;
        }

        private void treeParameters_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (param.Length > 0 && e.Node.Parent != null)
            {
                myProperty.Index = e.Node.Index;
                myProperty.Type = param[e.Node.Index].ParameterType;
                propertyGrid1.SelectedObject = myProperty;
            }
            else
                propertyGrid1.SelectedObject = null;

        }

        private void treeWsdl_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            treeParameters.Nodes.Clear();
            propertyGrid1.SelectedObject = null;
            treeOutput.Nodes.Clear();

            if (e.Node.Parent != null)
            {
                treeParameters.Nodes.Add(e.Node.Text);
                MethodName = e.Node.Text;
                param = methodInfo[e.Node.Index].GetParameters();
                myProperty = new properties(param.Length);

                // Get the Parameters Type
                paramTypes = new Type[param.Length];
                for (int i = 0; i < paramTypes.Length; i++)
                {
                    paramTypes[i] = param[i].ParameterType;
                }

                foreach (ParameterInfo temp in param)
                {

                    treeParameters.Nodes[0].Nodes.Add(temp.ParameterType.Name + "  " + temp.Name);

                }

                treeParameters.ExpandAll();
            }

        }

        private void invokeButton_Click(object sender, EventArgs e)
        {
            treeOutput.Nodes.Clear();


            object[] param1 = new object[param.Length];

            try
            {

                for (int i = 0; i < param.Length; i++)
                {
                    param1[i] = Convert.ChangeType(myProperty.MyValue[i], myProperty.TypeParameter[i]);
                }

                foreach (MethodInfo t in methodInfo)
                    if (t.Name == MethodName)
                    {
                        //Invoke Method
                        Object obj = Activator.CreateInstance(service);
                        Object response = t.Invoke(obj, param1);
                        treeOutput.Nodes.Add(t.Name);
                        treeOutput.Nodes[0].Nodes.Add("Result = " + response.ToString());
                        treeOutput.ExpandAll();
                        break;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void propertyGrid1_Validated(object sender, EventArgs e)
        {
            for (int i = 0; i < param.Length; i++)
            {
                if (treeParameters.Nodes[0].Nodes[i].Text != myProperty.MyValue[i])
                {
                    treeParameters.Nodes[0].Nodes[i].Text = param[i].ParameterType.Name + "  " + param[i].Name + " = " + myProperty.MyValue[i];
                }
            }
        }

        #endregion

        #region Members

        private MethodInfo[] methodInfo;
        private ParameterInfo[] param;
        private Type service;
        private Type[] paramTypes;
        private properties myProperty;
        private string MethodName = "";

        #endregion
 
      // End
    }
}