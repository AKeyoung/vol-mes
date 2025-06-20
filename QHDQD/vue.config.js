module.exports = {
  productionSourceMap: false,
  lintOnSave: false,
  devServer: {
    port: 8001,
    client: { //关闭错误自动弹出框
      overlay: false,
    },
    // overlay: {
    //   warning: false,
    //   errors: false
    // }
  },
  // plugins: [vue(),vuejsx({})],
  css: {
    //查看CSS属于哪个css文件
    sourceMap: true
  },
  configureWebpack: {
    module: {
      rules: [
        {
          test: /\.mjs$/,
          include: /node_modules/,
          type: "javascript/auto"
        },
      ]
    }
  },
  //https://cli.vuejs.org/zh/guide/html-and-static-assets.html#html
  chainWebpack: (config) => {
    // 移除 prefetch 插件
    config.plugins.delete('prefetch');
    //自下定义title
    config.plugin('html').tap((args) => {
      args[0].title = '智能管控系统';
      return args;
    });

    // 或者
    // 修改它的选项：
    // config.plugin('prefetch').tap(options => {
    //   options[0].fileBlacklist = options[0].fileBlacklist || []
    //   options[0].fileBlacklist.push(/myasyncRoute(.)+?\.js$/)
    //   return options
    // })
  }
  // configureWebpack: {
  //     plugins: [
  //         new webpack.optimize.MinChunkSizePlugin({
  //             minChunkSize: 100000 // 通过合并小于 minChunkSize 大小的 chunk，将 chunk 体积保持在指定大小限制以上
  //         })
  //     ]
  // }
};
