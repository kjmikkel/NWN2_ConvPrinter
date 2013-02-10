/* 
 * This file is part of ConversationPrinter.
 * ConversationPrinter is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * ConversationPrinter is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser Public License
 * along with ConversationPrinter. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NWN2Toolset;
using NWN2Toolset.Plugins;
using OEIShared;
using System.Windows;
using System.Windows.Forms;
using TD.SandBar;

namespace ConversationPrinter
    {
    public class ConversationPrinter : INWN2Plugin
        {

    private string name = "Conversation Printer";

    private MenuButtonItem m_cMenuItem;

    private void HandlePluginLaunch(object sender, EventArgs e)
        {
        frmConv form = new frmConv();
        form.Show();
        }

        public void Load(INWN2PluginHost cHost)
        {
        }

        public void Shutdown(INWN2PluginHost cHost)
        {
        }

        public void Startup(INWN2PluginHost cHost)
        {
            m_cMenuItem = cHost.GetMenuForPlugin(this);
            m_cMenuItem.Activate += new EventHandler(this.HandlePluginLaunch);
        }

        public void Unload(INWN2PluginHost cHost)
        {
        }

        public MenuButtonItem PluginMenuItem
        {
            get
            {
                return m_cMenuItem;
            }
        }

// Properties
        public string DisplayName
        {
            get
            {
                return name;
            }
        }

        public string MenuName
        {
            get
            {
                return name;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }


        public object Preferences
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        }
    }

