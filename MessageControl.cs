using System.Windows.Forms;

namespace deliverable_1
{
    internal class MessageControl : UserControl
    {
        private Message message;

        public MessageControl(Message message)
        {
            this.message = message;
        }
    }
}