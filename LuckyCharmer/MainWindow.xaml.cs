using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LuckyCharmer {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Stuff to read|*.txt;*.fluffy|Fluffy Thingies|*.fluffy";
            ofd.ShowDialog();
            //string bob = ofd.FileName;
            //MessageBox.Show(bob);
            try {
                String[] lines = File.ReadAllLines(ofd.FileName);
                MessageBox.Show(lines[0]);
            }catch(Exception ex) {

            } finally {

            }
        }

        private void btnSaveHero_Click(object sender, RoutedEventArgs e) {
            SaveFileDialog ofd = new SaveFileDialog();
            FileStream fs = null;
            try {
                MyClasses.SuperHero sup = new MyClasses.SuperHero();
                sup.FirstName = "Bat";
                sup.LastName = "Man";

                ofd.ShowDialog();

                fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, sup);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
              if (fs != null) fs.Close();
            }
        }
    }
}
