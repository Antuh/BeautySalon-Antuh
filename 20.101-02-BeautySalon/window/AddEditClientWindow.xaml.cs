using _20._101_02_BeautySalon.model;
using _20._101_02_BeautySalon.pages;
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
using _20._101_02_BeautySalon.classes;

namespace _20._101_02_BeautySalon.window
{
    /// <summary>
    /// Логика взаимодействия для AddEditClientWindow.xaml
    /// </summary>
    /*
     * public string ImgPath
        {
            get
            {
                var path = "pack://application:,,,/image/" + this.PhotoPath;
                return path;
            }
        }
        public List<Tag> TagList
        {
            get
            {
                return this.Tag.ToList();
            }
        }
        public string CountService
        {
            get
            {
                return this.ClientService.Count.ToString();

            }
        }

        public System.DateTime DateService
        {
            get
            {
                using (Entities db = new Entities()) 
                {
                    return db.ClientService
                             .Where(c => c.ClientID == this.ID)
                             .OrderByDescending(c => c.StartTime)
                             .Select(c => c.StartTime)
                             .FirstOrDefault();
                }
            }
        }
        public int GenderList
        {
            get
            {
                return Convert.ToInt32(this.GenderCode) - 1; ;
            }
        }
        public List<ClientService> ServiceList
        {
            get
            {
                return this.ClientService.ToList();
            }
        }
     */
    public partial class AddEditClientWindow : Window
    {
        Client client = new Client();
        private Entities db;
        Client currentClient = new Client();
        private ClientPage clientPage;

        public AddEditClientWindow(Client currentClient, Entities db, ClientPage clientPage)
        {
            InitializeComponent();
            this.clientPage = clientPage;
            this.db = db;
            if (currentClient != null)
            {
                this.client = currentClient;
                LViewTags.ItemsSource = client.TagList;
                tbID.Text = client.ID.ToString();
            }
            else if (currentClient == null)
            {
                this.currentClient = currentClient;
                btnDeleteClient.IsEnabled = false;
                TagGrid.Visibility = Visibility.Collapsed;
                spID.Visibility = Visibility.Collapsed;
            }
            DataContext = client;
            cmbGender.ItemsSource = db.Gender.ToList();
        }

        
        private void Phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validacia.ValidPhone(e.Text);
        }

        private void tbFirstName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validacia.ValidFIO(e.Text);
        }
        private void tbPatronymic_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validacia.ValidFIO(e.Text);
        }

        private void tbLastName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validacia.ValidFIO(e.Text);
        }

        private void tbEmail_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Validacia.ValidEmailAddress(e.Text);
        }

        private void tbColorTag_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (tbColorTag.Text.Length >= 6 && !e.Text.Equals("\b"))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = !Validacia.ValidColor(e.Text);
            }
        }

        private void btnDelTag_Click(object sender, RoutedEventArgs e)
        {
            int count = LViewTags.SelectedItems.Count;
            if (count > 0)
            {
                if (MessageBox.Show($"Вы действительно хотите удалить {count} запись", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    try
                    {
                        var selected = LViewTags.SelectedItems.Cast<Tag>().ToArray();
                        foreach (var item in selected)
                        {
                            db.Tag.Remove(item);
                        }
                        db.SaveChanges();
                        string about;
                        if (count == 1) about = "Тег удален!";
                        else about = "Теги удалены!";
                        MessageBox.Show(about, "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        LViewTags.ItemsSource = client.TagList;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите теги для удаления", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnAddTag_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                Errors(tbColorTag.Text == "", errors, "Введите цвет!");
                Errors(tbTitleTag.Text == "", errors, "Заголовог тега!");
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                Tag tag = new Tag
                {
                    ID = db.Tag.Any() ? db.Tag.Max(t => t.ID) + 1 : 1,
                    Title = tbTitleTag.Text,
                    Color = tbColorTag.Text
                };
                client.Tag.Add(tag);
                db.SaveChanges();
                tbTitleTag.Text = ""; tbColorTag.Text = "";
                LViewTags.ItemsSource = client.TagList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                Errors(cmbGender.SelectedItem == null, errors, "Выберите пол клиента!");
                Errors(tbFirstName.Text.Count() > 50, errors, "Фамилия не может быть длиннее 50 символов!");
                Errors(tbLastName.Text.Count() > 50, errors, "Имя не может быть длиннее 50 символов!");
                Errors(tbPatronymic.Text.Count() > 50, errors, "Отчество не может быть длиннее 50 символов!");
                Errors(tbFirstName.Text == ""
                    || tbLastName.Text == ""
                    || tbPhone.Text == "", errors, "Не заполнена важная ифнормация!");
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                if (currentClient == null)
                {
                    client.RegistrationDate = DateTime.Now;
                    RefrData();
                    db.Client.Add(client);
                    SaveInDB("Добавление информации о клиенте завершено");
                }
                else
                {
                    RefrData();
                    SaveInDB("Обновление информации о клиенте завершено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RefrData()
        {
            client.Birthday = (DateTime)dpBirthDate.SelectedDate;
            client.GenderCode = (cmbGender.SelectedIndex + 1).ToString();
        }

        private void SaveInDB(string text)
        {
            db.SaveChanges();
            MessageBox.Show(text, "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void Errors(bool expression, StringBuilder errors, string message)
        {
            if (expression)
            {
                errors.AppendLine(message);
            }
        }

        private void btnDeleteClient_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (client.ClientService.Count > 0)
                {
                    MessageBox.Show("Удаление не возможно, т.к. есть информация о посещении", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                foreach (Tag tag in client.Tag)
                {
                    db.Tag.Remove(tag);
                }
                db.Client.Remove(client);
                db.SaveChanges();
                MessageBox.Show("Удаление информации об клиенте завешено!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddAndEditClientWindow_Closed(object sender, EventArgs e)
        {
            try
            {
                if (clientPage != null)
                {
                    clientPage.Load(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
