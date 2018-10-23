﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mystivate.Models;

namespace Mystivate.Code.Database
{
    public class CharacterAccess : ICharacterAccess
    {
        private readonly Mystivate_dbContext _dbContext;
        public CharacterAccess(Mystivate_dbContext db)
        {
            _dbContext = db;
        }

        public int AddExperience(int userId, int amount)
        {
            Character character = _dbContext.Characters.Where(c => c.UsersId == userId).First();
            if (character.Experience.HasValue)
            {
                character.Experience += amount;
            }
            else
            {
                character.Experience = amount;
            }
            _dbContext.SaveChanges();
            return character.Experience.Value;
        }

        public Character GetCharacter()
        {
            throw new NotImplementedException();
        }

        public int GetCoins(int userId)
        {
            throw new NotImplementedException();
        }

        public int GetExperience(int userId)
        {
            Character character = _dbContext.Characters.Where(c => c.UsersId == userId).First();
            if (character.Experience.HasValue)
            {
                return character.Experience.Value;
            }
            else
            {
                return 0;
            }
        }

        public int GetLives(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
