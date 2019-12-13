<template>
  <div class="swiper-container" v-if="movies.length">
    <div class="swiper-wrapper">
      <div class="swiper-slide" v-for="(item, index) in movies" :key="index">
        <router-link :to="{path: '/movie/'+item.id}" class="linkto">
          <figure>
            <img v-lazy="imgBaseUrl + item.imgsrc" />
            <figcaption>{{item.title}}</figcaption>
          </figure>
        </router-link>
      </div>
    </div>
    <div class="swiper-pagination"></div>
  </div>
  <img src="../../assets/swipe.png" class="fl_back animation_opactiy" v-else />
</template>
<script>
import { mapState, mapActions } from "vuex";
import { imgBaseUrl } from "src/config/env";
import "src/plugins/swiper.min.js";
import "src/style/swiper.min.css";
export default {
  data() {
    return {
      imgBaseUrl: imgBaseUrl,
      movies: []
    };
  },
  mounted() {
    this.getMovies("top", 3, 5)
      .then(r => (this.movies = r))
      .then(
        r =>
          new Swiper(".swiper-container", {
            pagination: ".swiper-pagination",
            loop: true
          })
      );
  },
  methods: {
    ...mapActions(["getMovies"])
  }
};
</script>
<style lang="scss" scoped>
@import "src/style/mixin";
.swiper-container {
  @include wh(100%, 5.6rem);
  padding-bottom: 0.6rem;
  .swiper-pagination {
      padding-bottom: 0.1rem;
  }
  .linkto {
    @include wh(100%, 100%);
    figure {
      @include wh(100%, 100%);
      img {
        @include wh(100%, 100%);
      }
      figcaption {
        text-align: center;
        @include sc(0.55rem, #666);
      }
    }
  }
}
.fl_back {
  @include wh(100%, 100%);
}
</style>