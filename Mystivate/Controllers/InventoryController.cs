﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mystivate.Logic;
using Mystivate.Models;

namespace Mystivate.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ICharacterInfo _characterInfo;
        private readonly IInventoryLogic _inventoryLogic;

        public InventoryController(ICharacterInfo characterInfo, IInventoryLogic inventoryLogic)
        {
            _characterInfo = characterInfo;
            _inventoryLogic = inventoryLogic;
        }

        public IActionResult Index()
        {
            Character model = _characterInfo.GetCharacterInfo(true);
            return View(model);
        }

        public void SetWearing(int equipmentId)
        {
            _inventoryLogic.SetEquipment(equipmentId);
        }

        public int[] GetWearing()
        {
            return _inventoryLogic.GetInventory(true).Select(e => e.Id).ToArray();
        }
    }
}