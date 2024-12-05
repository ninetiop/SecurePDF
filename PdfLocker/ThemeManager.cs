using System;
using System.Drawing;
using System.Windows.Forms;

namespace PdfLocker
{
    public static class ThemeManager
    {
        public static bool IsDarkTheme { get; private set; } = false;

        // Couleurs pour le thème Cyberpunk
        private static readonly Color cyberpunkBackColor = Color.FromArgb(30, 30, 46); // Gris très foncé
        private static readonly Color cyberpunkAccentViolet = Color.FromArgb(187, 134, 252); // Violet néon
        private static readonly Color cyberpunkAccentBlue = Color.FromArgb(3, 218, 198); // Bleu néon

        // Couleurs pour le thème clair
        private static readonly Color lightBackColor = Color.White;
        private static readonly Color lightForeColor = Color.Black;
        private static readonly Color lightButtonBorderColor = Color.LavenderBlush; // Bordures spécifiques au thème clair

        /// <summary>
        /// Applique le thème Cyberpunk avec un accent de couleur au choix (violet ou bleu).
        /// </summary>
        /// <param name="form">La Form sur laquelle appliquer le thème.</param>
        /// <param name="useVioletAccent">Si true, applique un accent violet, sinon bleu.</param>
        public static void ApplyCyberpunkTheme(Form form, bool useVioletAccent = true)
        {
            IsDarkTheme = true;
            Color accentColor = useVioletAccent ? cyberpunkAccentViolet : cyberpunkAccentBlue;
            ApplyTheme(form, cyberpunkBackColor, accentColor);
        }

        /// <summary>
        /// Applique le thème clair.
        /// </summary>
        /// <param name="form">La Form sur laquelle appliquer le thème.</param>
        public static void ApplyLightTheme(Form form)
        {
            IsDarkTheme = false;
            ApplyTheme(form, lightBackColor, lightForeColor);
        }

        /// <summary>
        /// Applique un thème donné à une Form et à ses contrôles enfants.
        /// </summary>
        private static void ApplyTheme(Form form, Color backColor, Color foreColor)
        {
            form.BackColor = backColor;
            form.ForeColor = foreColor;
            UpdateControls(form, backColor, foreColor);
        }

        /// <summary>
        /// Met à jour les couleurs de tous les contrôles dans la Form.
        /// </summary>
        private static void UpdateControls(Control parent, Color backColor, Color foreColor)
        {
            foreach (Control control in parent.Controls)
            {
                switch (control)
                {
                    case Button btn:
                        if (btn.Name == "buttonLightMode" || btn.Name == "buttonDarkMode")
                        {
                            // Boutons Light et Dark Mode : Supprimer les bordures
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.FlatAppearance.BorderSize = 0; // Pas de bordure
                            btn.BackColor = backColor; // Conserve le thème général pour le fond
                            btn.ForeColor = foreColor; // Conserve le thème général pour le texte
                        }
                        else
                        {
                            // Autres boutons : comportement normal
                            btn.BackColor = backColor;
                            btn.ForeColor = foreColor;
                            btn.FlatStyle = FlatStyle.Flat;
                            if (backColor == lightBackColor) // Thème clair
                            {
                                btn.FlatAppearance.BorderColor = lightButtonBorderColor;
                                btn.FlatAppearance.BorderSize = 2;
                            }
                            else // Thème sombre
                            {
                                btn.FlatAppearance.BorderColor = foreColor;
                                btn.FlatAppearance.BorderSize = 1;
                            }
                        }
                        break;

                    case Label lbl:
                        lbl.ForeColor = foreColor;
                        break;

                    case TextBox txt:
                        txt.BackColor = backColor == lightBackColor ? Color.WhiteSmoke : Color.FromArgb(40, 40, 60);
                        txt.ForeColor = foreColor;
                        txt.BorderStyle = BorderStyle.FixedSingle;
                        break;

                    case CheckBox chk:
                        chk.BackColor = backColor;
                        chk.ForeColor = foreColor;
                        break;

                    case TrackBar trk:
                        trk.BackColor = backColor;
                        break;

                    case TabControl tabControl:
                        tabControl.BackColor = backColor;
                        tabControl.ForeColor = foreColor;
                        foreach (TabPage tabPage in tabControl.TabPages)
                        {
                            tabPage.BackColor = backColor;
                            tabPage.ForeColor = foreColor;
                            UpdateControls(tabPage, backColor, foreColor);
                        }
                        break;

                    case MenuStrip menu:
                        menu.BackColor = backColor;
                        menu.ForeColor = foreColor;
                        foreach (ToolStripMenuItem menuItem in menu.Items)
                        {
                            UpdateMenuStripItems(menuItem, backColor, foreColor);
                        }
                        break;

                    case Panel pnl:
                    case GroupBox grp:
                        control.BackColor = backColor;
                        control.ForeColor = foreColor;
                        break;
                }

                // Récursivité pour les sous-contrôles
                if (control.HasChildren)
                {
                    UpdateControls(control, backColor, foreColor);
                }
            }
        }


        /// <summary>
        /// Met à jour les couleurs des éléments dans un MenuStrip.
        /// </summary>
        private static void UpdateMenuStripItems(ToolStripMenuItem menuItem, Color backColor, Color foreColor)
        {
            menuItem.BackColor = backColor;
            menuItem.ForeColor = foreColor;

            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    UpdateMenuStripItems(subMenuItem, backColor, foreColor);
                }
            }
        }
    }
}
