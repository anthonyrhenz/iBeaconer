using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Resources;

//bonus imports ;)
//using Windows.Storage;
//using Windows.Data;
//using Windows.Services;
using Windows.Storage.Streams;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Bluetooth.Background;

namespace iBeaconer
{
    public partial class mainWin : Form
    {
        public BluetoothLEAdvertisementPublisher publisher;

        public List<string> names { get; set; } = new List<string>();
        public List<string> uuids { get; set; } = new List<string>();
        public List<string> majorpair { get; set; } = new List<string>();
        public List<string> minorpair { get; set; } = new List<string>();

        public mainWin()
        {
            InitializeComponent();

            /*
            using (var Reader = new StreamReader(@".\positions.csv"))
            {
                List<string> names = new List<string>();
                while (!Reader.EndOfStream)
                {
                    var line = Reader.ReadLine();
                    var values = line.Split(',');

                    names.Add(values[0]);
                    uuids.Add(values[1]);
                    majorpair.Add(values[2]);
                    minorpair.Add(values[3]);
                }


                roomSelect.DataSource = names;
                Debug.WriteLine(names[3]);
                Debug.WriteLine(majorpair[3]);
                Debug.WriteLine(minorpair[3]);
            }
            */

            string[] csvPos = Properties.Resources.positions.Split('\n');
            foreach (string s in csvPos)
            {
                var values = s.Split(',');
                names.Add(values[0]);
                uuids.Add(values[1]);
                majorpair.Add(values[2]);
                minorpair.Add(values[3]);
            }

            //moved all init to func

            
                //create manufacturer UUID
                ////drastic updates.
                /*
                var writer = new DataWriter();
                UInt16 uuidData = 0x1234;
                writer.WriteUInt16(uuidData);

                manufacturerData.Data = writer.DetachBuffer();
                //add manufacturer data to our gun
                publisher.Advertisement.ManufacturerData.Add(manufacturerData);

                ///now we create our payload.
                //payload = new BluetoothLEAdvertisement();
                Guid guid = Guid.Parse("00001804-0000-1000-8000-00805f9b34fb");
                publisher.Advertisement.ServiceUuids.Add(guid);

                publisher.Advertisement.Flags = BluetoothLEAdvertisementFlags.GeneralDiscoverableMode;
                */
            

            
        }

        public void execute_Click(object sender, EventArgs e) //it's time.
        {

            //begin construction for advert
            BluetoothLEAdvertisementPublisher publisher = new BluetoothLEAdvertisementPublisher();

            //create/set manufacturer ID
            var manufacturerData = new BluetoothLEManufacturerData();
            manufacturerData.CompanyId = 0x004c; //apple inc's company data

            if (major.Text==string.Empty || minor.Text==string.Empty || uuid.Text==string.Empty)
            {
                MessageBox.Show("ur autistic, put some values in.");
                return;
            }

            //process our user input data
            var majorhex = Convert.ToInt32(major.Text).ToString("X").PadLeft(4,'0');
            var minorhex = Convert.ToInt32(minor.Text).ToString("X").PadLeft(4,'0');
            string maj1 = Convert.ToString(majorhex[0])+majorhex[1];
            string maj2 = Convert.ToString(majorhex[2])+majorhex[3];
            string min1 = Convert.ToString(minorhex[0])+minorhex[1];
            string min2 = Convert.ToString(minorhex[2])+minorhex[3];

            string[] hold = uuid.Text.Split(' ');

            // Create the payload
            //harrison004: f0207da6-4fa2-4e98-8024-bc5b71e0893e  |  6  |  11
            // f0 20 7d a6 4f a2 4e 98 80 24 bc 5b 71 e0 89 3e

            //harrison 209
            // f0 20 7d a6 4f a2 4e 98 80 24 bc 5b 71 e0 89 3e  |  6  |  179
            var writer = new DataWriter();

            byte[] dataArray = new byte[23];
            int i = 2;
            dataArray[0] = byte.Parse("02", System.Globalization.NumberStyles.AllowHexSpecifier);
            dataArray[1] = byte.Parse("15", System.Globalization.NumberStyles.AllowHexSpecifier);
            foreach (string item in hold)
            {
                dataArray[i++] = byte.Parse(item, System.Globalization.NumberStyles.AllowHexSpecifier);
            }
            dataArray[18] = byte.Parse(maj1, System.Globalization.NumberStyles.AllowHexSpecifier);
            dataArray[19] = byte.Parse(maj2, System.Globalization.NumberStyles.AllowHexSpecifier);
            dataArray[20] = byte.Parse(min1, System.Globalization.NumberStyles.AllowHexSpecifier);
            dataArray[21] = byte.Parse(min2, System.Globalization.NumberStyles.AllowHexSpecifier);
            dataArray[22] = byte.Parse("B3", System.Globalization.NumberStyles.AllowHexSpecifier);

            /*
            byte[] dataArray = new byte[] {
                // last 2 bytes of Apple's iBeacon
                0x02, 0x15,
                // UUID e2 c5 6d b5 df fb 48 d2 b0 60 d0 f5 a7 10 96 e0
                0xf0, 0x20, 0x7d, 0xa6,
                0x4f, 0xa2, 0x4e, 0x98,
                0x80, 0x24, 0xbc, 0x5b,
                0x71, 0xe0, 0x89, 0x3e,
                // Major
                0x00, 0x06,
                // Minor
                0x00, 0x0B,
                // TX power
                0xc5
            };
            */

            writer.WriteBytes(dataArray);

            manufacturerData.Data = writer.DetachBuffer();
            publisher.Advertisement.ManufacturerData.Add(manufacturerData);


            publisher.Start(); //begin the spoof ;)

            indicator.ForeColor = Color.Green;
        }

        public void stop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're welcome ;)");
            Application.Exit();

            indicator.ForeColor = Color.Red;
        }


        /// <summary>
        /// Room Select to grab beacons
        /// </summary>
        /// <param name="sender">dont know</param>
        /// <param name="e">dont care</param>
        private void roomSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = roomSelect.SelectedIndex;

            uuid.Text = uuids[a];
            major.Text = majorpair[a];
            minor.Text = minorpair[a];

            /*switch (roomSelect.SelectedItem)
            {
                case "Harrison 004":
                    uuid.Text = "f0 20 7d a6 4f a2 4e 98 80 24 bc 5b 71 e0 89 3e";
                    major.Text = "6";
                    minor.Text = "11";
                    break;
                case "Harrison 209":
                    uuid.Text = "f0 20 7d a6 4f a2 4e 98 80 24 bc 5b 71 e0 89 3e";
                    major.Text = "6";
                    minor.Text = "156";
                    break;
            }*/
        }

        private void major_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void minor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void uuid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!((ch >= 'A' && ch <= 'F') || (ch >= 48 && ch <= 57) || (ch == 32) || (ch >= 'a' && ch <= 'f') || (ch == 127) || (ch == 08) ))
            e.Handled = true;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            uuid.Text = Clipboard.GetText();
        }

        private void roomSelect_Click(object sender, EventArgs e)
        {
            roomSelect.DataSource = names;
        }
    }
}
