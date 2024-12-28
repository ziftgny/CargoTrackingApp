﻿using Business.Abstracts;
using Core.Entities;
using DataAccess.Abstract;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class KargoManager : IKargoService
    {
        IKargoDal _kargoDal;

        public KargoManager(IKargoDal kargoDal)
        {
            _kargoDal = kargoDal;
        }

        public void Add(Kargo entity)
        {
            _kargoDal.Add(entity);
        }

        public void Delete(Kargo entity)
        {
            _kargoDal.Delete(entity);
        }

        public List<Kargo> GetAll()
        {
            return _kargoDal.GetAll();
        }

        public Kargo GetById(int id)
        {
           return _kargoDal.Get(p => p.id == id);
        }

        public void Update(Kargo entity)
        {
            _kargoDal.Update(entity);
        }
    }
}