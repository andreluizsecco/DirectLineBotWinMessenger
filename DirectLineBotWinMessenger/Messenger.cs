using Microsoft.Bot.Connector.DirectLine;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectLineBotWinMessenger
{
    public partial class Messenger : Form
    {
        private string _botId;
        private string _directLineSecret;
        private DirectLineClient _directLineClient;
        private Conversation _conversation;

        public Messenger()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BotIdTextBox.Text) && !string.IsNullOrEmpty(DirectLineSecretTextBox.Text))
            {
                _botId = BotIdTextBox.Text.Trim();
                _directLineSecret = DirectLineSecretTextBox.Text.Trim();

                groupBox.Enabled = true;
                MessageTextBox.Focus();

                Task.Run(() => StartBotConversation());
            }
            else
                MessageBox.Show("Os campos BotId e DirectLineSecret são obrigatórios!");
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MessageTextBox.Text.Length > 0)
            {
                Activity userMessage = new Activity
                {
                    From = new ChannelAccount("UserTest"),
                    Text = MessageTextBox.Text,
                    Type = ActivityTypes.Message
                };

                Task.Run(() => _directLineClient.Conversations.PostActivityAsync(_conversation.ConversationId, userMessage));

                WriteMessage("UserTest", MessageTextBox.Text);
                MessageTextBox.Text = string.Empty;
                MessageTextBox.Focus();
            }
        }

        private async Task StartBotConversation()
        {
            _directLineClient = new DirectLineClient(_directLineSecret);
            _conversation = await _directLineClient.Conversations.StartConversationAsync();

            if (_conversation == null)
                MessageBox.Show("Erro ao se conectar, confira se o BotId e DirectLineSecret estão corretos!");

            Task.Run(async () => await ReadBotMessagesAsync(_directLineClient, _conversation.ConversationId)).Start();
        }

        private async Task ReadBotMessagesAsync(DirectLineClient client, string conversationId)
        {
            string watermark = null;

            while (true)
            {
                var activitySet = await client.Conversations.GetActivitiesAsync(conversationId, watermark);
                watermark = activitySet?.Watermark;

                var activities = from x in activitySet.Activities
                                 where x.From.Id == _botId
                                 select x;

                foreach (Activity activity in activities)
                {
                    WriteMessage(activity.From.Name, activity.Text);

                    if (activity.Attachments.Count > 0)
                        WriteMessage("Messenger", "Um anexo foi enviado, porém esse messenger não dá suporte a exibição do mesmo.");
                }

                await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
            }
        }

        public void WriteMessage(string sender, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, string>(WriteMessage), new object[] { sender, message });
                return;
            }
            ConversationTextBox.Text += $"{sender}: {message}\r\n\r\n";
        }
    }
}
