using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoIT
{
    public partial class Video_Settings : Form
    {
        #region init
        public Video_Settings()
        {
            InitializeComponent();
        }
        #endregion

        #region Vars
        config data;
        #endregion

        #region Func
        /// <summary>
        /// Get object from another class =D
        /// </summary>
        /// <param name="obj"></param>
        public void setObj(Object obj) {
            data = (config)obj;
        }
        #endregion

        #region Events
        /// <summary>
        /// Pass textbox data to var data, clear and close this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clicked(object sender, EventArgs e)
        {
            
            data.VideoUrl = videofield.Text;
            videofield.Text = string.Empty;
            this.Close();
        }
        #endregion
    }
}
