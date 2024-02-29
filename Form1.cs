using Lab1.database;
using System.Media;
using System.Reflection;
using System;
using System.IO;
using System.Xml.Serialization;
using Lab1.Models.Interfaces;
using Lab1.Models;
using Lab1.Managers;


namespace Lab1
{
    public partial class Form1 : Form
    {
        private ComboBoxManager CBM;


        public Form1()
        {
            InitializeComponent();
            CBM = new ComboBoxManager(caseCB, coolerCB, cpuCB, dataCB, gpuCB, motherboardCB, powerCB, ramCB, totalSumLabel);

            CBM.InitializeComboBoxes();
            CBM.BindSelectedIndexChangedEvents();
        }
   
        private void label2_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            // Формирование пути к файлу звука
            string soundPath = Path.Combine(currentDirectory, "Sounds", "Secret.wav");

            SoundPlayer soundPlayer = new SoundPlayer(soundPath);
            soundPlayer.Play();

        }

        private void saveBuildButton_Click(object sender, EventArgs e)
        {
            List<int?> details = CBM.GetSelectedIds();
            decimal finalSum = decimal.Parse(totalSumLabel.Text);

            // позорно строим объект компьютера (ноу билдер)
            PC myPC = new PC(
                details[0],                               ////////////////
                details[1],                              //            //
                details[2],                             //            //
                details[3],                            ////////////////
                details[4],                                  ////
                details[5],                                  ////
                details[6],                            ///////////////
                details[7],
                finalSum
                );

            //Console.WriteLine( myPC.ToString() ); // debug point
            using (var context = new ApplicationDbContext())
            {
                context.PCs.Add(myPC);
                context.SaveChanges();

                MessageBox.Show($"Ваша сборка успешно сохранена\nID: {myPC.Id}");
            }
        }
    }
}
