

Thread t1 = new Thread(M1);
Task tt1 = new Task(M1);

Thread t2 = new Thread(() => { MM1(10, "abc"); });
Task tt2 = new Task(() => { MM1(10, "xyz"); });

Task<int> t3 = new Task<int>(M3);
t3.Start();
//
//sdfsdf
//sfsdf
int r = t3.Result;
//jkhjkh

Task<int> t4 = new Task<int>(() => { return M4(10); });
t4.Start();
//
r = t4.Result;


static void MM1(int a, string str) { }
static void M1() { }

static void M2(int a) { }

static int M3() { return 10; }

static int M4(int a) { return 10; }