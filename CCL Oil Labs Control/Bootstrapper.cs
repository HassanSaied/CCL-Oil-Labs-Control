﻿using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Unity;
using CCL_Oil_Labs_Control.Views;
using Prism.Modularity;
using CCL_Oil_Labs_Control.CompositeCommands;
using CCL_Oil_Labs_Control.ViewModels;
using CCL_Oil_Labs_Control.Model;
using Prism.Events;
namespace CCL_Oil_Labs_Control 
{
    class Bootstrapper : UnityBootstrapper
    {
        DatabaseEntities model = DatabaseEntities.Initiate();
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        protected override void InitializeShell()
        {
            
            Application.Current.MainWindow.Show();
        }
        
          protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //TODO : Remove Magic String
            Container.RegisterType<CloseCommand, CloseCommand>(new ContainerControlledLifetimeManager());
            Container.RegisterType<AddingCodesNavigateCommand, AddingCodesNavigateCommand>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IGLobalNavigateCommand, GlobalNavigateCommand>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IApplicationCommands, FillDataAndNavigateCommand>(new ContainerControlledLifetimeManager());
            Container.RegisterType<EntryMenuViewModel, EntryMenuViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<AddNewUsrMenuViewModel, AddNewUsrMenuViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<EditUsrMenuViewModel, EditUsrMenuViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<CodesRegAnlMenuViewModel, CodesRegAnlMenuViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<CodesRegAnlTypeMenuViewModel, CodesRegAnlTypeMenuViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<CodesRegExpDetailsMenuViewModel, CodesRegExpDetailsMenuViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<ChemicalElectricalAnalysisViewModel, ChemicalElectricalAnalysisViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<ReportsMainMenuViewModel, ReportsMainMenuViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<TransformerReportViewModel, TransformerReportViewModel>(new ContainerControlledLifetimeManager());
            Container.RegisterType<recordReport, recordReport>(new ContainerControlledLifetimeManager());
            Container.RegisterTypeForNavigation<EntryMenu>("EntryMenu");
            Container.RegisterTypeForNavigation<MainMenu>("MainMenu");
            Container.RegisterTypeForNavigation<CodesAddingMenu>("CodesAddingMenu");
            Container.RegisterTypeForNavigation<CodesRegSampleDataMenu>("CodesRegSampleDataMenu");
            Container.RegisterTypeForNavigation<CodesRegCoMenu>("CodesRegCoMenu");
            Container.RegisterTypeForNavigation<AddNewUsrMenu>("AddNewUsrMenu");
            Container.RegisterTypeForNavigation<EditUsrMenu>("EditUsrMenu");
            Container.RegisterTypeForNavigation<CodesRegCoTypeMenu>("CodesRegCoTypeMenu");
            Container.RegisterTypeForNavigation<CodesRegEquipNamesMenu>("CodesRegEquipNamesMenu");
            Container.RegisterTypeForNavigation<CodesRegStationsMenu>("CodesRegStationsMenu");
            Container.RegisterTypeForNavigation<CodesRegAnlMenu>("CodesRegAnlMenu");
            Container.RegisterTypeForNavigation<CodesRegAnlTypeMenu>("CodesRegAnlTypeMenu");
            Container.RegisterTypeForNavigation<CodesRegExpDetailsMenu>("CodesRegExpDetailsMenu");
            Container.RegisterTypeForNavigation<ChemicalElectricalAnalysis>("ChemicalElectricalAnalysis");
            Container.RegisterTypeForNavigation<ReportsMainMenu>("ReportsMainMenu");
            Container.RegisterTypeForNavigation<TransformerReport>("TransformerReport");
            Container.RegisterTypeForNavigation<recordReport>("recordReport");
        }
    }
}
