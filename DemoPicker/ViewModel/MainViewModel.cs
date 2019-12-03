using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DemoPicker.Model;
using MvvmHelpers;

namespace DemoPicker.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private EntityItem _selectedItem;
        private string _selectedId;

        public MainViewModel()
        {
            LoadItems();
        }

        public ObservableCollection<EntityItem> PickerItems { get; } = new ObservableCollection<EntityItem>();

        public EntityItem SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (SetProperty(ref _selectedItem, value) && value != null)
                {
                    OnItemSelected();
                }
            }
        }

        public string SelectedId
        {
            get => _selectedId;
            set => SetProperty(ref _selectedId, value);
        }

        private void OnItemSelected()
        {
            SelectedId = SelectedItem.Id.ToString();
        }

        private async Task LoadItems()
        {
            //TODO: Add your api logic

            var items = new[]
            {
                new EntityItem
                {
                    Title = "Item 1"
                },
                new EntityItem
                {
                    Title = "Item 2"
                },
                new EntityItem
                {
                    Title = "Item 3"
                },
                new EntityItem
                {
                    Title = "Item 4"
                }
            };

            foreach (var item in items)
            {
                PickerItems.Add(item);
            }
        }
    }
}
