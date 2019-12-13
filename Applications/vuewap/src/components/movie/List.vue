<template>
  <div>
    <ul v-load-more="loaderMore" v-if="movies.length" type="1">
      <detail v-for="(item,index) in movies" :key="index" :param="item"></detail>
    </ul>
    <ul v-else class="animation_opactiy">
      <li class="list_back_li" v-for="item in 10" :key="item">
        <img src="../../assets/shopback.svg" class="list_back_svg" />
      </li>
    </ul>
    <p v-if="touchend" class="empty_data">不能加载更多了</p>
    <aside class="return_top" @click="backTop" v-if="showBackStatus">
      <svg class="back_top_svg">
        <use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#backtop" />
      </svg>
    </aside>
    <div ref="abc" style="background-color: red;"></div>
    <transition name="loading">
      <loading v-show="showLoading"></loading>
    </transition>
  </div>
</template>
<script>
import detail from "./ListDetail";
import { mapState, mapActions } from "vuex";
import { showBack, animate } from "src/config/mUtils";
import { loadMore, getImgPath } from "src/components/common/mixin";
import loading from "src/components/common/loading";
export default {
  data() {
    return {
      page: 1,
      pagesize: 5,
      preventRepeatReuqest: false, //到达底部加载数据，防止重复加载
      showBackStatus: false, //显示返回顶部按钮
      showLoading: true, //显示加载动画
      touchend: false, //没有更多数据
      movies: []
    };
  },
  props: {
    param: {
      type: Object,
      default: function() {
        return {
          type: ""
        };
      }
    }
  },
  mixins: [loadMore],
  components: {
    detail,
    loading
  },
  mounted() {
    this.initData();
  },
  //   watch: {
  //     param: async function(value, old) {
  //       this.movies = await this.getMovies(
  //         value.type,
  //         value.page,
  //         value.pagesize
  //       );
  //     }
  //   },
  methods: {
    ...mapActions(["getMovies", "getUserInfo"]),
    async initData() {
      //获取数据
      this.getMovies(this.param.type, this.page, this.pagesize).then(r => {
        this.movies = r;
        if (r.length < this.pagesize) this.touchend = true;
      });

      this.showLoading = false;
      //开始监听scrollTop的值，达到一定程度后显示返回顶部按钮
      showBack(status => {
        this.showBackStatus = status;
      });
    },
    //到达底部加载更多数据
    async loaderMore() {
      if (this.touchend) {
        return;
      }
      //防止重复请求
      if (this.preventRepeatReuqest) {
        return;
      }
      this.showLoading = true;
      this.preventRepeatReuqest = true;

      this.page++;
      if(this.page>5) this.touchend = true;
      this.getMovies(this.param.type, this.page, this.pagesize).then(r => {
        this.movies = [...this.movies, ...r];
        if (r.length < this.pagesize) this.touchend = true;
        this.showLoading = false;
        this.preventRepeatReuqest = false;
      });
    }
  }
};
</script>
<style lang="scss" scoped>
@import "src/style/mixin";

.loader_more {
  @include font(0.6rem, 3);
  text-align: center;
  color: #999;
}
.empty_data {
  @include sc(0.5rem, #666);
  text-align: center;
  line-height: 2rem;
}
.return_top {
  position: fixed;
  bottom: 3rem;
  right: 1rem;
  .back_top_svg {
    @include wh(2rem, 2rem);
  }
}
.loading-enter-active,
.loading-leave-active {
  transition: opacity 1s;
}
.loading-enter,
.loading-leave-active {
  opacity: 0;
}
</style>