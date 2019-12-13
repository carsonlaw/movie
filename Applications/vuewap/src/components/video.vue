<template>
  <div>
      {{param.src}}
    <video id="myVideo" class="video-js"></video>
  </div>
</template>

    <script>
import Video from "video.js";
import "video.js/dist/video-js.css";

export default {
  data() {
    return {
      myPlayer: {}
    };
  },
  props: {
    param: {
      type: Object,
      default: function() {
        return {
          src: "",
          type: ""
        };
      }
    }
  },
  mounted() {
    this.initVideo();
  },
  watch: {
    param: function(n, old) {
      this.myPlayer.pause();
      this.myPlayer.src({ src: n.src, type: n.type });
      this.myPlayer.play();
    }
  },
  methods: {
    initVideo() {
      this.myPlayer = Video(myVideo, {
        //确定播放器是否具有用户可以与之交互的控件。没有控件，启动视频播放的唯一方法是使用autoplay属性或通过Player API。
        controls: true,
        //自动播放属性,muted:静音播放
        autoplay: "muted",
        //建议浏览器是否应在<video>加载元素后立即开始下载视频数据。
        preload: "auto",
        //设置视频播放器的显示宽度（以像素为单位）
        width: "800px",
        //设置视频播放器的显示高度（以像素为单位）
        height: "400px"
      });
      //this.myPlayer.src({ src: this.param.src, type: this.param.type });
    }
  }
};
</script>

<style scoped>
</style>