using System;

namespace Gestao.dominio
{
    public abstract class Entity
    {
        public string RecordCreateBy { get; private set; }
        public string RecordUpdateBy { get; private set; }
        public DateTime? RecordCreateDate { get; private set; }
        public DateTime? RecordUpdateDate { get; private set; }


        public void SetRecordCreateBy(string user)
        {
            RecordCreateBy = user;
        }
        public void SetRecordUpdateBy(string user)
        {
            RecordUpdateBy = user;
        }      
        public void SetRecordCreateDate()
        {
            RecordCreateDate = DateTime.Now;
        }     
        public void SetRecordUpdateDate()
        {
            RecordUpdateDate = DateTime.Now;
        }
    }
}
