using Lab1.database;
using Lab1.models;
using Lab1.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using static Lab1.Form1;

namespace Lab1.Managers
{
    public class ComboBoxManager
    {
        private ComboBox caseCB, coolerCB, cpuCB, dataCB, gpuCB, motherboardCB, powerCB, ramCB;
        private decimal totalSum;
        private Label totalSumLabel;

        private class ComboBoxItem
        {
            public string DisplayText { get; set; }
            public object Model { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        public ComboBoxManager(
            ComboBox caseCB, 
            ComboBox coolerCB, 
            ComboBox cpuCB, 
            ComboBox dataCB, 
            ComboBox gpuCB, 
            ComboBox motherboardCB, 
            ComboBox powerCB, 
            ComboBox ramCB, 
            Label totalSumLabel
            ) 
        {
            this.totalSumLabel = totalSumLabel;
            this.caseCB = caseCB;
            this.coolerCB = coolerCB;
            this.cpuCB = cpuCB;
            this.dataCB = dataCB;
            this.gpuCB = gpuCB;
            this.motherboardCB = motherboardCB;
            this.powerCB = powerCB;
            this.ramCB = ramCB;
        }

        public void BindSelectedIndexChangedEvents()
        {
            caseCB.SelectedIndexChanged += UpdateTotalSum;
            coolerCB.SelectedIndexChanged += UpdateTotalSum;
            cpuCB.SelectedIndexChanged += UpdateTotalSum;
            dataCB.SelectedIndexChanged += UpdateTotalSum;
            gpuCB.SelectedIndexChanged += UpdateTotalSum;
            motherboardCB.SelectedIndexChanged += UpdateTotalSum;
            powerCB.SelectedIndexChanged += UpdateTotalSum;
            ramCB.SelectedIndexChanged += UpdateTotalSum;
        }

        public void InitializeComboBoxes()
        {
            using (var context = new ApplicationDbContext())
            {
                AddItemsToComboBox(context.Cases, caseCB, c => $"{c.Brand} {c.Model} ({c.Price} руб.)");
                AddItemsToComboBox(context.Coolers, coolerCB, c => $"{c.Brand} {c.Model} ({c.Price} руб.)");
                AddItemsToComboBox(context.CPUs, cpuCB, c => $"{c.Brand} {c.Model} {c.GHz}GHz ({c.Price} руб.)");
                AddItemsToComboBox(context.DataStorages, dataCB, d => $"{d.Type} {d.Brand} {d.Model} {d.Storage}GB ({d.Price} руб.)");
                AddItemsToComboBox(context.GPUs, gpuCB, g => $"{g.Brand} {g.Model} {g.VRAM}GB ({g.Price} руб.)");
                AddItemsToComboBox(context.Motherboards, motherboardCB, m => $"{m.Brand} {m.Chipset} {m.Model} ({m.Price} руб.)");
                AddItemsToComboBox(context.PowerSupplies, powerCB, p => $"{p.Brand} {p.Model} {p.W}W ({p.Price} руб.)");
                AddItemsToComboBox(context.RAMs, ramCB, r => $"{r.Brand} {r.Model} {r.Storage}GB ({r.Price} руб.)");
            }
        }

        private void AddItemsToComboBox<T>(IEnumerable<T> details, ComboBox comboBox, Func<T, string> displayTextFunc)
        {
            var items = details
                .Select(d => new ComboBoxItem { DisplayText = displayTextFunc(d), Model = d })
                .ToArray();

            comboBox.Items.AddRange(items);
        }

        public List<int?> GetSelectedIds()
        {
            List<int?> selectedIds = new List<int?>();

            selectedIds.Add(GetSelectedItemId(caseCB.SelectedItem));
            selectedIds.Add(GetSelectedItemId(coolerCB.SelectedItem));
            selectedIds.Add(GetSelectedItemId(cpuCB.SelectedItem));
            selectedIds.Add(GetSelectedItemId(dataCB.SelectedItem));
            selectedIds.Add(GetSelectedItemId(gpuCB.SelectedItem));
            selectedIds.Add(GetSelectedItemId(motherboardCB.SelectedItem));
            selectedIds.Add(GetSelectedItemId(powerCB.SelectedItem));
            selectedIds.Add(GetSelectedItemId(ramCB.SelectedItem));

            return selectedIds;
        }

        private void UpdateTotalSum(object sender, EventArgs e)
        {
            totalSum = 0;

            totalSum += GetSelectedItemPrice(caseCB.SelectedItem);
            totalSum += GetSelectedItemPrice(coolerCB.SelectedItem);
            totalSum += GetSelectedItemPrice(cpuCB.SelectedItem);
            totalSum += GetSelectedItemPrice(dataCB.SelectedItem);
            totalSum += GetSelectedItemPrice(gpuCB.SelectedItem);
            totalSum += GetSelectedItemPrice(motherboardCB.SelectedItem);
            totalSum += GetSelectedItemPrice(powerCB.SelectedItem);
            totalSum += GetSelectedItemPrice(ramCB.SelectedItem);

            totalSumLabel.Text = $"{totalSum}";
        }

        private decimal GetSelectedItemPrice(object selectedItem)
        {
            if (selectedItem is ComboBoxItem comboBoxItem && comboBoxItem.Model is IPriceable priceableItem)
            {
                return priceableItem.Price;
            }

            return 0m;
        }

        private int? GetSelectedItemId(object selectedItem)
        {
            if (selectedItem is ComboBoxItem comboBoxItem && comboBoxItem.Model is IIdentifiable identifiableItem)
            {
                return identifiableItem.Id;
            }

            return null;
        }

    }
}
