using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meme_explorer.Client.Controls {
    public partial class ItemTabGroup : UserControl {

        protected List<ItemTab> currentTabs;
        public ItemTab currentActiveTab;

        public ItemTabGroup() {
            InitializeComponent();
            currentTabs = new List<ItemTab>();
        }

        private void ItemTabGroup_Load(object sender, EventArgs e) {

        }

        private void ItemTabGroup_Paint(object sender, PaintEventArgs e) {
            
        }

        public ItemTab AddTabToGroup(ItemTab tab){
            if (!currentTabs.Contains(tab)) {
                //TODO: setup click event
                currentTabs.Add(tab);
                return currentTabs.Find(tb => tb == tab);
            }
            else{
                return null;
            }
        }

        protected void ExecuteOnList(Action function){
            foreach(ItemTab tab in currentTabs){
                function();
            }
        }

        public void HandleClicking(ItemTab clickedTab, MouseEventArgs e) {
            if (currentActiveTab != clickedTab) {
                currentActiveTab.isSelected = false;
                clickedTab.isSelected = true;
            }
        }
    }
}
