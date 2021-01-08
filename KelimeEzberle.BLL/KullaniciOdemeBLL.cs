﻿using KelimeEzberleDAL;
using KelimeEzberleEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzberle.BLL
{
    public class KullaniciOdemeBLL
    {
        KullaniciOdemeDAL _odemeDAL;

        public KullaniciOdemeBLL()
        {
            _odemeDAL = new KullaniciOdemeDAL();
        }

        public bool KullaniciOdemeEkle(KullaniciOdeme kullaniciOdeme)
        {
            try
            {
                KullaniciDogrulama(kullaniciOdeme.KullaniciID);
                OdemeDogrulama(kullaniciOdeme.KullaniciID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _odemeDAL.KullaniciOdemeEkle(kullaniciOdeme);
        }
        public List<KullaniciOdeme> YapilanOdemeler()
        {
            return _odemeDAL.YapilanOdemeler();
        }
        public decimal ToplamCiro()
        {
            return _odemeDAL.ToplamCiro();
        }
        public decimal ToplamCiro(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            try
            {
                TarihKarsilastir(baslangicTarihi, bitisTarihi);
                return _odemeDAL.ToplamCiro(baslangicTarihi, bitisTarihi);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        void TarihKarsilastir(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            if (bitisTarihi < baslangicTarihi)
            {
                throw new Exception("Bitiş tarihi, başlangıç tarihinden eski bir tarih olamaz.");
            }
        }
        private void OdemeDogrulama(int kullaniciID)
        {
            List<KullaniciOdeme> kullaniciOdeme = _odemeDAL.YapilanOdemeler();
            foreach (KullaniciOdeme item in kullaniciOdeme)
            {
                if (item.KullaniciID == kullaniciID)
                {
                    throw new Exception("Bir kullanıcı sadece bir kez ödeme yapabilir.");
                }
            }
        }
        void KullaniciDogrulama(int kullaniciID)
        {
            KullaniciBLL kullanici = new KullaniciBLL();
            Dictionary<string, object> kullaniciOdeme = new Dictionary<string, object>();
            kullaniciOdeme = kullanici.KullaniciOdemesiGetir(kullaniciID);
            if (kullaniciOdeme != null)
            {
                throw new Exception("Kullanıcı zaten ödeme yapmıştır.");
            }
        }

    }
}
