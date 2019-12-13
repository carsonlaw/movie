<template>
  <div>
    <detail v-for="(item,index) in movies" :key="index" :param="item"></detail>
  </div>
</template>
<script>
import detail from "./CardDetail";
import { mapState, mapActions } from "vuex";
export default {
  data() {
    return {
      movies: []
    };
  },
  props: {
    param: {
      type: Object,
      default: function() {
        return {
          type: "",
          page: "",
          pagesize
        };
      }
    }
  },
  components: {
    detail
  },
  mounted() {
    this.getMovies(this.param.type, this.param.page, this.param.pagesize).then(
      r => (this.movies = r)
    );
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
    ...mapActions(["getMovies", "getUserInfo"])
  }
};
</script>
<style lang="scss" scoped>
@import "src/style/mixin";
div {
  display: flex;
  flex-wrap: wrap;
  .linkto {
    width: 25%;
    padding: 0.3rem 0rem;
    @include fj(center);
    figure {
      img {
        margin-bottom: 0.3rem;
        @include wh(1.8rem, 1.8rem);
      }
      figcaption {
        text-align: center;
        @include sc(0.55rem, #666);
      }
    }
  }
}
</style>