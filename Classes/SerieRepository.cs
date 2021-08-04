using System;
using System.Collections.Generic;
using DIO.series.ale.Interface;

namespace DIO.series.ale
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSeries = new List<Serie>();

        public void Add(Serie entity)
        {
            this.listSeries.Add(entity);
        }
        public List<Serie> List()
        {
            return this.listSeries;
        }
        public void Update(int id, Serie entity)
        {
            this.listSeries[id] = entity;
        }

        public void Exclude(int id)
        {
            //this.listSeries.RemoveAt(id);
            this.listSeries[id].Excluding();

        }

        public int NextId()
        {
            return this.listSeries.Count;
        }

        public Serie ReturnFromId(int id)
        {
            return this.listSeries[id];
        }

    }
}
