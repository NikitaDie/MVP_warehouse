using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using ViewLayout;
using ViewLayout.Views;

namespace Forms.MenuForms
{
    public partial class SearchPackageForm : Form, ISearchPackageView
    {
        public List<string> AutoCompleteSource
        {
            set
            {
                _autoCompleteCollection = new AutoCompleteStringCollection();
                _autoCompleteCollection.AddRange(value.ToArray());
                //textBoxSearchPackage.AutoCompleteCustomSource = _autoCompleteCollection;
                listBox1.DataSource = _autoCompleteCollection;
            }
        }

        public string InputText => textBoxSearchPackage.Text;

        private AutoCompleteStringCollection? _autoCompleteCollection;

        public event Action? InputChanged;
        public event Action? GetPackageInfo;

        public SearchPackageForm()
        {
            InitializeComponent();

            textBoxSearchPackage.TextChanged += (sender, args) => Invoke(InputChanged);
            listBox1.Click += (sender, args) => Invoke(GetPackageInfo);
        }

        private new void Invoke(Action? action)
        {
            try
            {
                action?.Invoke();
            }
            catch { throw; };
        }

        public int Y
        {
            get => Location.Y;
            set => Location = Location with { Y = value };
        }

        public new void Show()
        {
            Location = new Point(Location.X, Location.Y + Height);
            base.Show();
            FluentTransitions.Transition.With(this, nameof(Y), 0).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

        public new void Close()
        {
            FluentTransitions.Transition.With(this, nameof(Y), Location.Y - Height).
                HookOnCompletionInUiThread(this, () => base.Close()).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

        public void LoadNewForm(IView newForm)
        {
            Form _currentForm = newForm as Form;
            _currentForm.TopLevel = false;
            _currentForm.TopMost = true;
            _currentForm.FormBorderStyle = FormBorderStyle.None;
            this.labelPanel.Controls.Add(_currentForm);

            //CurrentForm = newForm;
            newForm.Show();
        }

        public string GetLabelID()
        {
            string? id = listBox1.GetItemText(listBox1.SelectedItem);
            id ??= string.Empty;

            return id;
        }
    }
}
