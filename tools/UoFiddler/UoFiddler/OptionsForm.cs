﻿/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

using System.Windows.Forms;
using Ultima;

namespace UoFiddler
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            checkBoxAltDesign.Checked = FiddlerControls.Options.DesignAlternative;
            checkBoxCacheData.Checked = Files.CacheData;
            checkBoxNewMapSize.Checked = (Ultima.Map.Felucca.Width == 7168);
            numericUpDownItemSizeWidth.Value = FiddlerControls.Options.ArtItemSizeWidth;
            numericUpDownItemSizeHeight.Value = FiddlerControls.Options.ArtItemSizeHeight;
            checkBoxItemClip.Checked = FiddlerControls.Options.ArtItemClip;
            checkBoxUseHash.Checked = Files.UseHashFile;
        }

        private void OnClickApply(object sender, System.EventArgs e)
        {
            if (checkBoxAltDesign.Checked != FiddlerControls.Options.DesignAlternative)
            {
                FiddlerControls.Options.DesignAlternative = checkBoxAltDesign.Checked;
                UoFiddler.ChangeDesign();
            }
            Files.CacheData = checkBoxCacheData.Checked;
            if (checkBoxNewMapSize.Checked != (Ultima.Map.Felucca.Width == 7168))
            {
                if (checkBoxNewMapSize.Checked)
                {
                    Ultima.Map.Felucca.Width = 7168;
                    Ultima.Map.Trammel.Width = 7168;
                }
                else
                {
                    Ultima.Map.Felucca.Width = 6144;
                    Ultima.Map.Trammel.Width = 6144;
                }
                UoFiddler.ChangeMapSize();
            }
            if ((numericUpDownItemSizeWidth.Value != FiddlerControls.Options.ArtItemSizeWidth)
                || (numericUpDownItemSizeHeight.Value != FiddlerControls.Options.ArtItemSizeHeight))
            {
                FiddlerControls.Options.ArtItemSizeWidth = (int)numericUpDownItemSizeWidth.Value;
                FiddlerControls.Options.ArtItemSizeHeight = (int)numericUpDownItemSizeHeight.Value;
                UoFiddler.ReloadItemTab();
            }
            if (checkBoxItemClip.Checked != FiddlerControls.Options.ArtItemClip)
            {
                FiddlerControls.Options.ArtItemClip = checkBoxItemClip.Checked;
                UoFiddler.ReloadItemTab();
            }
            Files.UseHashFile = checkBoxUseHash.Checked;
        }
    }
}