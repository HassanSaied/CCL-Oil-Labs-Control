﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL_Oil_Labs_Control.Model
{
    public partial class Station
    {

        public static ObservableCollection<Station> getStations(int companyName , int CompanyType)
        {
            var model = DatabaseEntities.Initiate();
            DatabaseEntities.clearEntity<Company>();
            (from station in model.Stations where station.CompanyName == companyName && station.CompanyType == CompanyType select station).Load();
            return DatabaseEntities.Initiate().Stations.Local;
        }

        public static ObservableCollection<Station> getStations(int companyName, int CompanyType,string stationName)
        {
            DatabaseEntities.clearEntity<Station>();
            var model = DatabaseEntities.Initiate();
            return new ObservableCollection<Station>((from station in model.Stations
             where station.CompanyName == companyName && 
             station.CompanyType == CompanyType && 
             station.Name == stationName
             select station));
        }


    }
}
