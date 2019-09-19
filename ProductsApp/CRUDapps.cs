using System;
using System.Windows.Forms;

namespace ProductsApp
{
    public partial class CRUDapps : Form
    {
        private DBTable _Products;
        private int _IntervalItems = 40;
        int _StartItems;
        int _EndItems;
        public CRUDapps(DBConnection _DBConnection)
        {
            _Products = new DBTable(_DBConnection);
            _StartItems = 0;
            _EndItems = _StartItems + _IntervalItems;
            InitializeComponent();
            FillListBoxes();
        }
        public void FillListBoxes()
        {
            try
            {
                IdListBox.Items.Clear();
                CategoryListBox.Items.Clear();
                NameListBox.Items.Clear();
                PriceListBox.Items.Clear();
                LastModifiedListBox.Items.Clear();
                for (int i = _StartItems; i < _EndItems && i < _Products.Keys.Length; i++)
                {
                    IdListBox.Items.Add(_Products.Keys[i]);
                    CategoryListBox.Items.Add(_Products[_Products.Keys[i]].Category);
                    NameListBox.Items.Add(_Products[_Products.Keys[i]].Name);
                    PriceListBox.Items.Add(_Products[_Products.Keys[i]].Price);
                    LastModifiedListBox.Items.Add(_Products[_Products.Keys[i]].LastModified);
                }
            }
            catch {
                _StartItems = 0;
                _EndItems = _StartItems + _IntervalItems;
                FillListBoxes();
            }
        }
        private void SetTextBoxes()
        {
            IdTextBox.Text = IdListBox.GetItemText(IdListBox.SelectedItem);
            CategoryTextBox.Text = CategoryListBox.GetItemText(CategoryListBox.SelectedItem);
            NameTextBox.Text = NameListBox.GetItemText(NameListBox.SelectedItem);
            PriceTextBox.Text = PriceListBox.GetItemText(PriceListBox.SelectedItem);
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(IdTextBox.Text);
                string Category = CategoryTextBox.Text;
                string Name = NameTextBox.Text;
                string Price = PriceTextBox.Text.Replace(',', '.');
                try
                {
                    if (MessageBox.Show($"Estas segura de alterar este producto?\nCodigo : {Id}\nCategoria : {_Products[Id].Category}\nNombre : {_Products[Id].Name}\nPrecio : {_Products[Id].Price}\n\n" +
                        $"Por este:\nCodigo : {Id}\nCategoria : {Category}\nNombre : {Name}\nPrecio : {Price}",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Products[Id].Category = Category;
                        _Products[Id].Name = Name;
                        _Products[Id].PriceString = Price;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    FillListBoxes();
                    try
                    {
                        if (IdListBox.Items.Contains(Id) && CategoryListBox.Items.Contains(Category) && NameListBox.Items.Contains(Name) && PriceListBox.Items.Contains(Price))
                        {
                            IdListBox.SelectedItem = Id;
                        }
                    }
                    catch { }
                }
            }
            catch
            {
                MessageBox.Show("Uno o mas campos estan vacios y/o con un formato incorrecto\nCodigo : 000\nCategoria : Texto\nNombre : Texto\nPrecio : 000.00", "Error de Formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(IdTextBox.Text);
                string Category = CategoryTextBox.Text;
                string Name = NameTextBox.Text;
                string Price = PriceTextBox.Text.Replace(',', '.');
                try
                {
                    if (MessageBox.Show($"Estas segura de agregar este producto?\nCodigo : {Id}\nCategoria : {Category}\nNombre : {Name}\nPrecio : {Price}",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Products.Add(Id, Category, Name);
                        _Products[Id].PriceString = Price;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    FillListBoxes();
                    try
                    {
                        if (IdListBox.Items.Contains(Id) && CategoryListBox.Items.Contains(Category) && NameListBox.Items.Contains(Name) && PriceListBox.Items.Contains(Price))
                        {
                            IdListBox.SelectedItem = Id;
                        }
                    }
                    catch { }
                }
            }
            catch
            {
                MessageBox.Show("Uno o mas campos estan vacios y/o con un formato incorrecto\nCodigo : 000\nCategoria : Texto\nNombre : Texto\nPrecio : 000.00", "Error de Formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(IdTextBox.Text);
                try
                {
                    if (MessageBox.Show($"Estas segura de remover este producto?\nCodigo : {Id}\nCategoria : {_Products[Id].Category}\nNombre : {_Products[Id].Name}\nPrecio : {_Products[Id].Price}",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Products.Remove(Id);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    FillListBoxes();
                    try
                    {
                        string Category = CategoryTextBox.Text;
                        string Name = NameTextBox.Text;
                        decimal Price = Convert.ToDecimal(PriceTextBox.Text);
                        if (IdListBox.Items.Contains(Id) && CategoryListBox.Items.Contains(Category) && NameListBox.Items.Contains(Name) && PriceListBox.Items.Contains(Price))
                        {
                            IdListBox.SelectedItem = Id;
                        }
                    }
                    catch { }
                }
            }
            catch
            {
                MessageBox.Show("Uno o mas campos estan vacios y/o con un formato incorrecto\nCodigo : 000\nCategoria : Texto\nNombre : Texto\nPrecio : 000.00", "Error de Formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TextBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int Id = Convert.ToInt32(IdTextBox.Text);
                    bool contains = false;
                    foreach (int key in _Products.Keys)
                    {
                        if (key == Id)
                        {
                            contains = true;
                        }
                    }
                    if (contains)
                    {
                        UpdateButton_Click(null, null);
                    }
                    else
                    {
                        InsertButton_Click(null, null);
                    }
                }
                catch
                {
                    MessageBox.Show("Uno o mas campos estan vacios y/o con un formato incorrecto\nCodigo : 000\nCategoria : Texto\nNombre : Texto\nPrecio : 000.00", "Error de Formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void ListBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteButton_Click(null, null);
            }
        }
        public void MouseWheel_Event(object sender, MouseEventArgs e)
        {
            int ScrollSize = 5;
            try
            {
                if (e.Delta == 120)
                {
                    if (_StartItems > 0)
                    {
                        _StartItems -= ScrollSize;
                        _EndItems -= ScrollSize;
                    }
                }
                if (e.Delta == -120)
                {
                    if (_EndItems <= _Products.Keys.Length + 5)
                    {
                        _StartItems += ScrollSize;
                        _EndItems += ScrollSize;
                    }
                }
            }
            catch { }
            int percentage = _Products.Keys.Length / 100;
            if ((_StartItems / percentage) > 0)
            {
                vScrollBar.Value = _StartItems / percentage;
            }
            FillListBoxes();
            TextBoxEqualListBox();
        }
        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (_StartItems >= 0)
            {
                int percentage = _Products.Keys.Length / 100;
                _StartItems = e.NewValue * percentage;
                _EndItems = _StartItems + _IntervalItems;
            }
            FillListBoxes();
            TextBoxEqualListBox();
        }
        private void TextBoxEqualListBox()
        {
            try
            {
                int Id = Convert.ToInt32(IdTextBox.Text);
                string Category = CategoryTextBox.Text;
                string Name = NameTextBox.Text;
                decimal Price = Convert.ToDecimal(PriceTextBox.Text);
                if (IdListBox.Items.Contains(Id) && CategoryListBox.Items.Contains(Category) && NameListBox.Items.Contains(Name) && PriceListBox.Items.Contains(Price))
                {
                    IdListBox.SelectedItem = Id;
                }
            }
            catch { }
        }



    }
}