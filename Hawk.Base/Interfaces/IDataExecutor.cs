﻿using System.Collections.Generic;
using Hawk.Base.Utils.Plugins;
using Hawk.Core.Utils.Plugins;
using Hawk.ETL.Interfaces;
using Hawk.ETL.Plugins.Transformers;

namespace Hawk.Base.Interfaces
{
    public interface IDataExecutor : IColumnProcess
    {
        IEnumerable<IFreeDocument> Execute(IEnumerable<IFreeDocument> documents);
    }


    public abstract class DataExecutorBase : ToolBase, IDataExecutor
    {
     
     
        protected DataExecutorBase()
        {
         
            Enabled = true;
        }
  

   
        public override FreeDocument DictSerialize(Scenario scenario = Scenario.Database)
        {
            var dict = base.DictSerialize();
            dict.Add("Group", "Executor");
            return dict;
        }

     



        public abstract IEnumerable<IFreeDocument> Execute(IEnumerable<IFreeDocument> documents);

 
    }
}