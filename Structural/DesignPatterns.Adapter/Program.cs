using DesignPatterns.Adapter;

CryptClassC instance = new();

CryptClassCAdapter cryptClassCAdapter = new(instance);

cryptClassCAdapter.Encrypt("");
cryptClassCAdapter.Decrypt("");
cryptClassCAdapter.ToXmlByAdapter("");
cryptClassCAdapter.ToJsonByAdapter("");