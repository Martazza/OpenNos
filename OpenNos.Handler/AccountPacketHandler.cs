﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */
using OpenNos.Core;
using OpenNos.Core.Communication.Scs.Communication.Messages;
using OpenNos.DAL;
using OpenNos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNos.Handler
{
    public class AccountPacketHandler : PacketHandlerBase
    {
        private readonly CustomScsServerClient _client;

        public AccountPacketHandler(CustomScsServerClient client)
        {
            _client = client;
        }

        [Packet("OpenNos.EntryPoint")]
        public ScsTextMessage Initialize(int sessionId)
        {
            //load account by given SessionId
            AccountDTO account = DAOFactory.AccountDAO.LoadBySessionId(sessionId);
            Logger.Log.InfoFormat("Account with SessionId {0} has arrived.", sessionId);

            //TODO Initialize User
            return new ScsTextMessage();
        }
    }
}