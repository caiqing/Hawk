# 终于等到你: 图形化开源爬虫Hawk 3发布!
---

![hawk3启动页面](http://images2018.cnblogs.com/blog/287060/201805/287060-20180512202119241-2084353771.png)

超级图形化爬虫Hawk已经发布两年半时间了，2015年升级到第二版，收到上千条用户反馈(tucao)，100多个红包，总共666块五毛~一直想攒着这笔钱，去北境之王天通苑的龙德商场买最心爱的阿迪王！

啥，你不知道Hawk是什么？它是智能而强大的网络数据采集工具，全图形化无需编程，一些功能强大到作者自己都不会用(这是真的)，下面的文章有更多的细节：

[第一版: 【重磅开源】Hawk-数据抓取工具：简明教程](http://www.cnblogs.com/buptzym/p/5454190.html)

[设计Hawk背后的故事](http://www.cnblogs.com/buptzym/p/6252488.html)

Hawk开源地址如下，记得在全世界最大的同性交友网站上给沙漠君点个star~:

> Github.com/ferventdesert/Hawk

某天夜里，一位神秘人物突然加我微信，知道我是Hawk的设计者之后，二话不说就发了200块红包！在确认对方不是仙人跳之后。我赶紧给这位客户老爷千恩万谢，明天可以加鸡腿了！

这位VIP客户跟我语音聊了接近一个小时，在无数条对Hawk的赞美之后，话锋一转，说“你这Hawk用户体验好差，界面太丑了，就不能好好优化一下么？”  

我说：好啊，你来提需求，我来改？我们一拍即合！这位神秘人物，就叫他升哥吧(可惜不是妹子啊)

从17年10月份开始，我们开始了你织布来我缝衣的模式（好哲♂学），升哥负责测试，用户体验，提需求；我来负责改代码。宝刀未老的沙漠君竟然还能记得四五年前写的C#代码！平时工作太太太太忙了，只能抽周六日坐在马桶上优化代码，差点搞成前列腺炎！平日我们会在地铁和公交上，通过微信讨论各种体验细节，画风是这样的：

![image.png-517.5kB][1]{:height="100px" width="400px"}

这样的聊天记录少说上万条，我们脑暴更好的体验，更快的算法，抠每个交互细节，在有限的时间内尽可能打磨和优化Hawk这款产品。后来参与内测的同学越来越多，我也收到了更多的反馈。

时间过得好快，朝鲜改革开放了，杭州买房要摇号了，半年多瞬间过去了。经过无数个“死也不改版”，拥有多个重大功能更新，两百多个体验升级后，Hawk3总算千呼万唤屎出来啦！

那Hawk3带来哪些令客官老爷们吃惊的体验呢？我们重点说明Hawk3强化的功能，已有的介绍可参考之前的文章哦。

![吃手手](http://images2018.cnblogs.com/blog/287060/201805/287060-20180512201642686-325007988.png)

## 更智能的网页采集器

输入网址，点击【手气不错】，Hawk就会自动将所有高价值的数据表提取出来，相比上一代，更是支持智能排序和自定义，动动鼠标，就能在多个结果间来回筛选，点击确定就完成了！

![超级手气不错](http://images2018.cnblogs.com/blog/287060/201805/287060-20180512203827617-1470633207.gif)

手气不错不仅能列表，还能支持详情页，在链家页面上随便输入一个信息，点手气不错，房产的详细信息就都出来了！

![单文档模式的手气不错](http://images2018.cnblogs.com/blog/287060/201805/287060-20180512221426878-671049210.gif)

网页采集器不仅支持xpath，更能混合使用selector语法，搜索关键词还能实现页面自动定位跳转高亮，智能地让你想哭！ 除了显示html源码，还能以浏览器模式预览！

## 更易用的数据清洗

Hawk最引以为傲的功能是：用户可组装灵活的数据清洗任务，先洗菜再切菜，最后扔锅里爆炒，所见即所得。

Hawk3大幅度改进了用户体验，模仿播放器设计，你可以对任务的各个模块灵活修改，快进后退！处理数据就像播放岛国大片一样流畅刺激！

![更易用的数据清洗](http://images2018.cnblogs.com/blog/287060/201805/287060-20180512223428072-1414269646.gif)

可以将多个数据清洗任务互相调用，实现更复杂和高级的功能，新版提供了对子任务的更友好的配置界面，让你像写Python函数一样实现子任务。Hawk调用Python实现自定义处理的功能也得到了增强，支持引入一部分第三方库，处理数据更加灵活。

Hawk同样大大强化了调试功能，能够实时监控web请求数和频次，分析任务中模块的工作和异常，快速确定问题，再也不用担心一脸懵逼找不到bug了!

## 两百多个微创新！

一款软件，增加新功能不是重点，而是打磨核心功能，用无数个细节编织出的微创新。你会发现：

- 以往需要手工输入的文本框现在都支持下拉菜单自动提示
- 能更容易地暂停和取消正在运行的任务
- 错误弹窗更加人性化，支持拼音快速检索模块
...

##  超快的导出Excel/数据库

早期版本的Hawk，大数据导出Excel卡得让男人沉默，女人流泪。优化后的Excel导出速度提升了15倍，百万级数据都轻轻松松。

更何况，Hawk还支持了文件级数据库Sqlite，千万数据毫无压力。完全不需要配置，再也不用担心数据太多爆内存了！

##  想自动化部署的客官有福了！

新的Hawk支持从Windows命令行模式执行，大概是下面的样子:
> cmd> HawkScheduler project.xml task_name

在Hawk图形界面上设计工程，命令行输入工程名和任务名，即可直接执行任务，速度更快更轻量，但记得用执行器把数据导出到数据库或者文件里哦！

微软的跨平台战略太不给力，让Hawk支持Linux和Mac的成本实在太高了，所以目前依然只能在Windows上运行。由于更新较多，新的Hawk基本上不能支持以前的工程文件，好在爬虫配置一遍也不是费事，对吧^-^

--- 

哎呀太多了写不完，在使用过程中，你能慢慢发现这些细节和惊喜。

考虑到之前用户的使用习惯，大部分改进都是平滑的，但早期工程已经不兼容。界面依然很工科癌。说界面丑的妹子欢迎给我们提意见~

通过阅读文档和视频，研究教学工程，5分钟就能上手使用，半小时就能成为老司机。你肯定迫不及待地想问我在哪里下载？点击GitHub地址，即可到达项目主页，那里有下载地址，文档，视频教程，以及你想要的全部资料！

![在线快速链接](http://images2018.cnblogs.com/blog/287060/201805/287060-20180512224642865-586244898.png)


由于时间极度紧张，可能视频和文档还有不完全之处，请关注“沙漠之鹰”微信公众号，Hawk的消息会在第一时间推送给你~最后，如果使用中有任何问题和建议，欢迎加入QQ群546750531，或者在GitHub上发言答疑，如果你是程序员，那麻烦给这个开源项目点个star呗~~

祝使用Hawk愉快！

  [1]: http://static.zybuluo.com/buptzym/q5r2hq6dqfdwq7kpx46bs4r4/image.png
  
  [2]: http://images2018.cnblogs.com/blog/287060/201805/287060-20180512200931229-1222353789.png