using AcadMe.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AcadMe.Views
{
    /// <summary>
    /// Interaction logic for AddSubjectWindow.xaml
    /// </summary>
    public partial class AddSubjectWindow : Window
    {
        public AddSubjectWindow()
        {
            InitializeComponent();
        }
        public Subject? NewSubject { get; set; }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtcourseCode.Text) || string.IsNullOrEmpty(txtCredit.Text) || string.IsNullOrEmpty(cmbSubjectType.Text))
            {
                MessageBox.Show("You need to fill all the fields");
                return;
            }

            NewSubject = new Subject()
            {
                SemesterId = 1,
                CourseCode = txtcourseCode.Text,
                Title = txtTitle.Text,
                Credits = int.Parse(txtCredit.Text),
                Type =cmbSubjectType.Text,
                IsActive = true,
                IsAudit = chkAudit.IsChecked == true,
                HasPractical = chPractical.IsChecked == true,
            };
            DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
