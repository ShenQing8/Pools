# Pools

## 概述

Pools 是一个为 Unity 提供对象池功能的库。它包含多种对象池类，如通用类和专用于 GameObjects 的类。你也可以通过继承类来创建自定义对象池

## 特色

* Unity中用于对象池的众多类
* 提供通用对象池 `ObjectPool`
* 具有针对 GameObjects 的池化 `GameObjectPool`
* `SharedGameObjectPool` 可以替换 `Instantiate` and `Destroy`
* 回调函数通过 `IPoolCallbackReceiver`处理

## 设置

### 要求

* Unity 2019.4 or newer

### 安装

1. 从Window>Package Manager。
2. 点击“+”按钮，然后选择“从 git URL 添加包”。
3. 请输入以下网址：

```
https://github.com/ShenQing8/Pools.git
```
