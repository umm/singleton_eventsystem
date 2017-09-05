# What?

* 読み込み済のシーン内に EventSystem が存在しない場合に限り、自動的に EventSystem コンポーネントを生成します。

# Why?

* Additive に読み込む Scene を個別に開発している場合、開発中には EventSystem が居て欲しいという要件があったため。

# Install

```shell
$ npm install github:umm-projects/singleton_eventsystem.git
```

# Usage

* 任意の GameObject に SingletonEventSystem を Add Component するだけです。
  * GameObject 名は任意ですが、 EventSystem が望ましいでしょう。

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

