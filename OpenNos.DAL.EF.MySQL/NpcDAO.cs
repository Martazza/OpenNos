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

using AutoMapper;
using OpenNos.DAL.EF.MySQL.DB;
using OpenNos.DAL.Interface;
using OpenNos.Data;
using System.Collections.Generic;
using System.Linq;
using System;

namespace OpenNos.DAL.EF.MySQL
{
    public class NpcDAO : INpcDAO
    {
        public NpcDTO Insert(NpcDTO npc)
        {
            using (var context = DataAccessHelper.CreateContext())
            {
               
                    Npc entity = Mapper.Map<Npc>(npc);
                    context.npc.Add(entity);
                    context.SaveChanges();
                    return Mapper.Map<NpcDTO>(entity);
                
            }
        }
        #region Methods

        public IEnumerable<NpcDTO> LoadFromMap(short MapId)
        {
            using (var context = DataAccessHelper.CreateContext())
            {
                foreach (Npc npcobject in context.npc.Where(c => c.MapId.Equals(MapId)))
                {
                    yield return Mapper.Map<NpcDTO>(npcobject);
                }
            }
        }

        #endregion
    }
}