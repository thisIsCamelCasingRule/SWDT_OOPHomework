using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDT_OOP_Homework
{
    public abstract class Storage
    {
        protected String data;
        protected int size;

        public abstract String getData();

        public abstract void addData(String data);

        public abstract void deleteData();

        public abstract void changeData(String changes);

        protected void setSizeOfStorage(int value) => size = value;

    }

    public abstract class RemovableStorageAdditional: Storage 
    {
        protected int durationTime;
        protected String storageId;

        protected void setDurationTime() => durationTime = 50;

        protected String getStorageId()
        {
            return "0";
        }
    }

    public abstract class LocalStorageAdditional: Storage
    {
        protected String path;

        protected void setPath() => path = "C:\\";

        protected string getPath() { return path;  }
    }

    public abstract class WebStorageAdditional : Storage
    {
        protected int port;
        protected String adress;

        protected void setAdress() => adress = "http://localhost:";

        protected void setPort() => port = 8000;

        protected string getFullAdress() { return adress + port.ToString(); }
    }

    public class WebStorage : WebStorageAdditional
    {

        public WebStorage(string data, int size)
        {
            this.data = data;
            this.setPort();
            this.setAdress();
            this.size = size;
        }

        public override void addData(string data)
        {
            this.data += data;
        }

        public override void changeData(string changes)
        {
            this.data = changes;
        }

        public override void deleteData()
        {
            this.data = null;
        }

        public override string getData()
        {
            return data;
        }
    }
    public class LocalStorage : LocalStorageAdditional
    {
        public LocalStorage(string data, int size)
        {
            this.data = data;
            this.setPath();
            this.size = size;
        }

        public override void addData(string data)
        {
            this.data += data;
        }

        public override void changeData(string changes)
        {
            this.data = changes;
        }

        public override void deleteData()
        {
            this.data = null;
        }

        public override string getData()
        {
            return data;
        }
    }

    public class RemovableStorage : RemovableStorageAdditional
    {
        public RemovableStorage(String data, int size)
        {
            this.data = data;
            this.durationTime = 50;
            this.storageId = "0";
            this.size = size;
        }

        public override void changeData(string changes)
        {
            this.data = changes;
        }

        public override void deleteData()
        {
            this.data = null;
        }

        public override string getData()
        {
            return data;
        }

        public override void addData(string data)
        {
            this.data += data;
        }
    }
}
