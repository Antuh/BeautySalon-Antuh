using _20._101_02_BeautySalon.classes;
using _20._101_02_BeautySalon.model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _20._101_02_BeautySalon.window
{
    /// <summary>
    /// Логика взаимодействия для EditServices.xaml
    /// </summary>
    public partial class EditServices : Window
    {
        Service service = new Service();
        Entities db;
        ClientServiceWindow clientServiceWindow;
        public EditServices(Service service, Entities db, ClientServiceWindow clientServiceWindow)
        {
            InitializeComponent();
            this.service = service;
            this.db = db;
            this.clientServiceWindow = clientServiceWindow;
            DataContext = service;
        }

        private void btnEnterImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog GetImageDialog = new OpenFileDialog();

                GetImageDialog.Filter = "Файлы изображений: (*.png, *.jpg, *jpeg)| *.png; *.jpg; *jpeg";
                GetImageDialog.InitialDirectory = "AutoService.Rule.Antuh\\Resourse\\Product";
                if (GetImageDialog.ShowDialog() == true) service.MainImagePath = GetImageDialog.SafeFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnDelImage_Click(object sender, RoutedEventArgs e)
            {
            try
            {
                string defaultImagePath = (string)FindResource("defaultImage"); 
                if (!string.IsNullOrEmpty(defaultImagePath))
                {
                    BitmapImage defaultImage = new BitmapImage(new Uri(defaultImagePath));
                    imgPhoto.Source = defaultImage; 
                }
                service.MainImagePath = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Errors(bool expression, StringBuilder errors, string message)
        {
            if (expression)
            {
                errors.AppendLine(message);
            }
        }

        private void btnRefrSer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                if (int.TryParse(TbDiscountServ.Text, out int discount))
                {
                    Errors(discount > 100, errors, "Скидка не может быть больше 100%");
                }
                Errors(TbTitleServ.Text == ""
                    || TbDurationInSecondsServ.Text == ""
                    || TbCostServ.Text == "", errors, "Не заполнена важная ифнормация!");
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                if (TbDiscountServ.Text == "") service.Discount = null;
                SaveInDB("Обновление информации о сервисе завершено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void SaveInDB(string text)
        {
            try
            {
                db.SaveChanges();
                this.Close();
                MessageBox.Show(text, "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelSer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Service.Remove(service);
                SaveInDB("Удаление информации о сервесе завешено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void TbTitleServ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (TbTitleServ.Text.Length >= 50 && !e.Text.Equals("\b"))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = !Validacia.ValidTitle(e.Text);
            }

        }

        private void TbDurationInSecondsServ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (TbDurationInSecondsServ.Text.Length >= 9 && !e.Text.Equals("\b"))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = !Validacia.ValidCost(e.Text);
            }
        }

        private void TbCostServ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            if (TbCostServ.Text.Contains(".") && e.Text == ".")
            {
                e.Handled = true;
            }
            else if (TbCostServ.Text.Length >= 11 && !e.Text.Equals("\b"))
            {
                e.Handled = true;
            }
            else
            {
                string newText = TbCostServ.Text.Insert(TbCostServ.CaretIndex, e.Text);
                e.Handled = !Validacia.ValidDiscount(newText);
            }
        }

        private void TbDiscountServ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            if (TbDiscountServ.Text.Length >= 3 && !e.Text.Equals("\b"))
            {
                e.Handled = true;
            }
            else
            {
                string newText = TbDiscountServ.Text.Insert(TbDiscountServ.CaretIndex, e.Text);
                if (!Validacia.ValidDiscount(newText) || (int.TryParse(newText, out int discount) && discount > 100))
                {
                    e.Handled = true;
                }
            }
        }

        private void TbDescriptionServ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (TbDescriptionServ.Text.Length >= 200 && !e.Text.Equals("\b"))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = !Validacia.ValidTitle(e.Text);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            try
            {
                if (clientServiceWindow != null)
                {
                    clientServiceWindow.Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
