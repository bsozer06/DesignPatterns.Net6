using DesignPatterns.Adapter;

var instance = new CryptClassC();

var cryptClassCAdapter = new CryptClassCAdapter(instance);

cryptClassCAdapter.Encrypt("");
cryptClassCAdapter.Decrypt("");
cryptClassCAdapter.ToXmlByAdapter("");
cryptClassCAdapter.ToJsonByAdapter("");