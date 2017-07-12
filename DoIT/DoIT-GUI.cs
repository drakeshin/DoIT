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
    public partial class DoIT : Form
    {
        #region init
        public DoIT()
        {
            InitializeComponent();
        }
        #endregion

        #region Var?
        /// <summary>
        /// Because YES =D
        /// </summary>
        config data = new config();
        #endregion

        #region Events
        /// <summary>
        /// Create/Open Form, pass obj.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clicked(object sender, EventArgs e)
        {
            Video_Settings form = new Video_Settings();
            form.setObj(data);
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        /// <summary>
        /// get url from obj and refresh this form =D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            shocker.Movie = data.VideoUrl;
            this.Refresh();
        }
        #endregion
    }
}
