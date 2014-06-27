using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IsolatedFileStorageApp.Resources;
using System.IO.IsolatedStorage;
using System.IO;

/************_Bipul Karki_*************
 * **********_CMPE-277_****************
 * **********_SJSU_Spring2014**********/

namespace IsolatedFileStorageApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            KeyValuePair<string, string> bookName = new KeyValuePair<string, string>(TextBlockBookName.Text, TextBoxBookName.Text);
            KeyValuePair<string, string> bookAuthor = new KeyValuePair<string, string>(TextBlockBookAuthor.Text, TextBoxBookAuthor.Text);
            KeyValuePair<string, string> bookDescription = new KeyValuePair<string, string>(TextBlockDescription.Text, TextBoxDescription.Text);

            IsolatedStorageFile fileStorage = IsolatedStorageFile.GetUserStoreForApplication();
            //create a file on root directory
            string sFile = "bookText.txt";
            if (!fileStorage.FileExists(sFile))
            {
                IsolatedStorageFileStream dataFile = fileStorage.CreateFile(sFile);
                dataFile.Close();
            }
            else
            {
                //Create a new StreamWriter, to write the file to the specified location.
                StreamWriter fileWriter = new StreamWriter(new IsolatedStorageFileStream("bookText.txt", FileMode.Append, fileStorage));
                //Write the key value pair list to the file.
                fileWriter.WriteLine(bookName);
                fileWriter.WriteLine(bookAuthor);
                fileWriter.WriteLine(bookDescription);
                //Close the StreamWriter.
                fileWriter.Close();
                TextBoxBookName.Text = string.Empty;
                TextBoxBookAuthor.Text = string.Empty;
                TextBoxDescription.Text = string.Empty;
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Terminate();
        }

        private void TextBoxBookName_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Text = string.Empty;
        }

        private void TextBoxBookAuthor_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Text = string.Empty;
        }

        private void TextBoxDescription_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Text = string.Empty;
        }

    }
}