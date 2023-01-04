using System;
using System.Windows.Forms;
using System.Xml;
using CoreScanner;

namespace ZebraSDKTest
{
    public partial class Form1 : Form
    {
        // Declare CoreScannerClass
        static CCoreScanner cCoreScannerClass;

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Instantiate CoreScanner Class
            cCoreScannerClass = new CCoreScanner();
            //Call Open API
            short[] scannerTypes = new short[1]; // Scanner Types you are interested in
            scannerTypes[0] = 2; // 1 for all scanner types
            short numberOfScannerTypes = 1; // Size of the scannerTypes array
            int status; // Extended API return code
            cCoreScannerClass.Open(0, scannerTypes, numberOfScannerTypes, out status);
            // Lets list down all the scanners connected to the host
            short numberOfScanners; // Number of scanners expect to be used
            int[] connectedScannerIDList = new int[255];
            // List of scanner IDs to be returned
            string outXML; //Scanner details output
            cCoreScannerClass.GetScanners(out numberOfScanners, connectedScannerIDList,
            out outXML, out status);
            Console.WriteLine(outXML);

            // Subscribe for barcode events in cCoreScannerClass
            cCoreScannerClass.BarcodeEvent += new
            _ICoreScannerEvents_BarcodeEventEventHandler(OnBarcodeEvent);

            // Let's subscribe for events
            int opcode = 1001; // Method for Subscribe events

            string inXML = "<inArgs>" +
            "<cmdArgs>" +
            "<arg-int>1</arg-int>" + // Number of events you want to subscribe
            "<arg-int>1</arg-int>" + // Comma separated event IDs
            "</cmdArgs>" +
            "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);
            Console.WriteLine(outXML);

            inXML = "<inArgs>" +
           "<cmdArgs>" +
           "<arg-int>2</arg-int>" + // Number of events you want to subscribe
           "<arg-int>1</arg-int>" + // Comma separated event IDs
           "</cmdArgs>" +
           "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);
            Console.WriteLine(outXML);

            inXML = "<inArgs>" +
           "<cmdArgs>" +
           "<arg-int>3</arg-int>" + // Number of events you want to subscribe
           "<arg-int>1</arg-int>" + // Comma separated event IDs
           "</cmdArgs>" +
           "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);
            Console.WriteLine(outXML);
        }

        void OnBarcodeEvent(short eventType, ref string pscanData)
        {
            var r = eventType;
            string barcode = pscanData;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(barcode);

            var scannerId = xmlDoc.GetElementsByTagName("scannerID");

            if (scannerId[0].InnerText=="1")
            {
                this.Invoke((MethodInvoker)delegate { textBox1.Text = xmlDoc.GetElementsByTagName("datalabel")[0].InnerText; });
            }
            else if (scannerId[0].InnerText == "2")
            {
                this.Invoke((MethodInvoker)delegate { textBox2.Text = barcode; });
            }
        }
    }
}
