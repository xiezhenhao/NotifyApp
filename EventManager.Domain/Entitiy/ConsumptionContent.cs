﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy
{
    class ConsumptionContent : EventContent<ConsumptionItem>
    {
        public ConsumptionContent()
        {
            
        }

        public override object Remark
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override object Summary
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
