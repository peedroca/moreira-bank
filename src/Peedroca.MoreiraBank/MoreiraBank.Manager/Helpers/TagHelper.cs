namespace MoreiraBank.Manager.Helpers
{
    internal static class TagHelper
    {
        public static Control? Find(Control.ControlCollection controls, string tag)
        {
            Control? control = null;

            foreach (Control c in controls)
            {
                if (c.Tag != null && c.Tag?.ToString() == tag)
                    return c;

                if (c.HasChildren)
                {
                    control = Find(c.Controls, tag);

                    if (control != null)
                        return control;
                }
            }

            return control;
        }
    }
}
