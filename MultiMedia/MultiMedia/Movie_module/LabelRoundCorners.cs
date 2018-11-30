using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMedia.Movie_module
{
    public partial class LabelRoundCorners : Component
    {
        public LabelRoundCorners()
        {
            InitializeComponent();
        }

        public LabelRoundCorners(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
