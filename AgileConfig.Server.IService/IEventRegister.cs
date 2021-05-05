﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AgileConfig.Server.IService
{
    public interface IEventRegister
    {
        void Init();
    }

    public class EventKeys
    {
        public const string ADMIN_LOGIN_SUCCESS = "ADMIN_LOGIN_SUCCESS";

        public const string INIT_ADMIN_PASSWORD_SUCCESS = "INIT_ADMIN_PASSWORD_SUCCESS";
        public const string RESET_ADMIN_PASSWORD_SUCCESS = "RESET_ADMIN_PASSWORD_SUCCESS";

        public const string ADD_APP_SUCCESS = "ADD_APP_SUCCESS";
        public const string EDIT_APP_SUCCESS = "EDIT_APP_SUCCESS";
        public const string DISABLE_OR_ENABLE_APP_SUCCESS = "DISABLE_OR_ENABLE_APP_SUCCESS";
        public const string DELETE_APP_SUCCESS = "DELETE_APP_SUCCESS";

        public const string ADD_SYSLOG = "ADD_SYSLOG";

        public const string ADD_RANGE_SYSLOG = "ADD_RANGE_SYSLOG";

    }
}
