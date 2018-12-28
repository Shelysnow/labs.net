using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Lab_IX
{public partial class MainWindow : Window
    {public MainWindow()
        {InitializeComponent();
         this.Title = "Приложение";
         button_save.IsEnabled = false;
        }
string Path = null;
        public static string DialogCall(string type)
        {switch (type){
        case "open":
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "TXT Files | *.txt";
        if (ofd.ShowDialog() == true) return ofd.FileName;
        else return null;
        case "save":
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.Filter = "TXT Files | *.txt";
        if (sfd.ShowDialog() == true) return sfd.FileName;
        else return null;
        default:
        throw new ArgumentException("Ошибка");
            }
        }
        private void button_Click(object sender, RoutedEventArgs r)
        {try
            {Path = DialogCall("open");
            using (StreamReader sr = new StreamReader(Path))
                {String line = sr.ReadToEnd();
                textBox.Text = line;
                }
                this.Title = Path;
            }
            catch(Exception exc)
            {MessageBox.Show(exc.Message);
            }
        }
        private void button_clear_Click(object sender, RoutedEventArgs r)
        {textBox.Clear();
        }
        private void button_save_Click(object sender, RoutedEventArgs r)
        {try
            {string savePath = Path ?? DialogCall("save");
            string[] lines = textBox.Text.Split('\n');
            File.WriteAllLines(savePath, lines);
            }
            catch(Exception exc1)
            {MessageBox.Show(exc1.Message);
            }
        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs r)
        {button_save.IsEnabled = true;
        }
        private void textBox_GotFocus(object sender, RoutedEventArgs r)
        {textBox = sender as TextBox;
        textBox.Foreground = Brushes.Black;
        textBox.Text = "";
        }
    }
}
