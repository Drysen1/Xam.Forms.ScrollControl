using ScrollControl.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ScrollControl.ViewModels
{
    public class GreenRedViewModel : BaseViewModel
    {
        private ObservableCollection<GreenRedModel> _greenRedList = new ObservableCollection<GreenRedModel>();

        public ObservableCollection<GreenRedModel> GreenRedList { get { return _greenRedList; } set { _greenRedList = value; OnPropertyChanged("GreenRedList"); } }

        public GreenRedViewModel()
        {
            GreenRedList = new ObservableCollection<GreenRedModel>()
            {
                new GreenRedModel(){ ID = 1, IsRedCell = false, ImgUrl = "https://images.unsplash.com/photo-1453078977505-10c3e375c2a0?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=c30ca6ca6ab9d7500b96198e108ab0ea&auto=format&fit=crop&w=1350&q=80" },
                new GreenRedModel(){ ID = 2, IsRedCell = true, ImgUrl = "https://images.unsplash.com/photo-1471478108131-9b2335c21611?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=3ff8f58159afd9410f46bf644d470c59&auto=format&fit=crop&w=1350&q=80" },
                new GreenRedModel(){ ID = 3, IsRedCell = false, ImgUrl = "https://images.unsplash.com/photo-1513612254505-fb553147a2e8?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=64b4ec64b69047202cd456a0420b920e&auto=format&fit=crop&w=1350&q=80" },
                new GreenRedModel(){ ID = 4, IsRedCell = false, ImgUrl = "https://images.unsplash.com/photo-1506100112881-fb9489aa0f92?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=77d1e2f5b288731dcccc4e6fbc6ae3ff&auto=format&fit=crop&w=1350&q=80" },
                new GreenRedModel(){ ID = 5, IsRedCell = true, ImgUrl = "https://images.unsplash.com/photo-1522952578391-59f9d9bb1ae2?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1660343f12713e00065208b07fe0b951&auto=format&fit=crop&w=1384&q=80" },
                new GreenRedModel(){ ID = 6, IsRedCell = true, ImgUrl = "https://images.unsplash.com/photo-1503428193604-2447f4935fe1?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=2b280aad2390e4bbabcd2ccce036b2ae&auto=format&fit=crop&w=1489&q=80" },
                new GreenRedModel(){ ID = 7, IsRedCell = false, ImgUrl = "https://images.unsplash.com/photo-1501785888041-af3ef285b470?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=cea32ac97f8ffde3f76df4a646ac8b4d&auto=format&fit=crop&w=1350&q=80" },
                new GreenRedModel(){ ID = 8, IsRedCell = false, ImgUrl = "https://images.unsplash.com/photo-1488188630656-ba26eafba904?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=f25ca4552ae081300ab292e21d8cc81c&auto=format&fit=crop&w=1353&q=80" },
                new GreenRedModel(){ ID = 9, IsRedCell = true, ImgUrl = "https://images.unsplash.com/photo-1488188630656-ba26eafba904?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=f25ca4552ae081300ab292e21d8cc81c&auto=format&fit=crop&w=1353&q=80" },
                new GreenRedModel(){ ID = 10, IsRedCell = false, ImgUrl = "https://images.unsplash.com/photo-1511381939415-e44015466834?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=232a6121d81f4dea55a84ea373af4559&auto=format&fit=crop&w=1438&q=80" },
            };
        }
    }
}
