using System;
using System.Windows.Forms;
namespace ProductsApp
{
    public partial class CRUDapps
    {
        public void ListBoxChange(int Index)
        {
            IdListBox.SelectedIndex = Index;
            CategoryListBox.SelectedIndex = Index;
            NameListBox.SelectedIndex = Index;
            PriceListBox.SelectedIndex = Index;
            LastModifiedListBox.SelectedIndex = Index;
            SetTextBoxes();
        }
        private void IdListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBoxChange(IdListBox.SelectedIndex);
        }
        private void CategoryListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBoxChange(CategoryListBox.SelectedIndex);
        }
        private void NameListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBoxChange(NameListBox.SelectedIndex);
        }
        private void PriceListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBoxChange(PriceListBox.SelectedIndex);
        }
        private void LastModifiedListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBoxChange(LastModifiedListBox.SelectedIndex);
        }
        private void IdListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxChange(IdListBox.SelectedIndex);
        }
        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxChange(CategoryListBox.SelectedIndex);
        }
        private void NameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxChange(NameListBox.SelectedIndex);
        }
        private void PriceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxChange(PriceListBox.SelectedIndex);
        }
        private void LastModifiedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxChange(LastModifiedListBox.SelectedIndex);
        }
    }
}
