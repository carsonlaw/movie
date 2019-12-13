<template>
  <div>
    <cvideo :param="videoparam"></cvideo>
    <movielist :param="{type:ref}"></movielist>
  </div>
</template>
<script>
import { mapState, mapActions } from "vuex";
import movielist from "src/components/movie/Card";
import cvideo from "src/components/video";
export default {
  data() {
    return {
      id: null,
      movie: null,
      videoparam: {
        src:
          //"https://youku.cdn7-okzy.com/share/b025cd6cde5038544af3b6bea29a7a5e",
          //"blob:https://youku.cdn7-okzy.com/0501433f-5476-487e-b2e0-f864b2b69850",
          "https://youku.cdn7-okzy.com/20191120/15855_5f73661e/index.m3u8",
        type: "application/x-mpegURL"
      }
    };
  },
  components: {
    cvideo,
    movielist
  },
  mounted() {
    this.id = this.$route.params.id;
    this.getMovieDetail(this.id).then(r => {
      this.movie = r;
    });
  },
  watch:{
    '$route' (to, from) {
      this.id = to.params.id;
      this.getMovieDetail(this.id).then(r => {
        this.movie = r;
    });
    }
  },
  methods: {
    ...mapActions(["getMovieDetail"])
  }
};
</script>
<style lang="sass" scoped>
@import "src/style/mixin";

</style>