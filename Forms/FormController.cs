using System;
using System.Collections.Generic;

namespace RedisChatClient.Forms
{
    internal class FormController
    {
        private static FormController instance;

        private Dictionary<String, IForm> inControl;

        private FormController()
        {
            inControl = new Dictionary<string, IForm>();
        }

        public static FormController getInstance()
        {
            if (instance == null)
            {
                instance = new FormController();
            }
            return instance;
        }

        public void addForm(String identifier, IForm form)
        {
            inControl.Add(identifier, form);
        }

        public IChatForm newChatForm()
        {
            return new ChatForm();
        }

        public IForm getForm(String identifier)
        {
            IForm form;
            inControl.TryGetValue(identifier, out form);
            return form;
        }

        public static void Init()
        {
            ///Boostraps form loaded and trapped here
            var me = getInstance();
            me.addForm("MainWindow", new MainWindow());
            me.addForm("SignIn", new SignIn());
            me.addForm("SignUp", new SignUp());
            me.addForm("UserInfo", new UserInfo());
            me.addForm("ListChat", new ListChat());
        }
    }
}