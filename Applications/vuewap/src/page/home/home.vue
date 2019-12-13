<template>
  <div>
    <movieswipe></movieswipe>
    <section>
      <span>最新</span>
      <router-link :to="{path: '/movies/dy'}"><span>...更多</span></router-link>
    </section>
    <movielist :param="{type:123}"></movielist>
  </div>
</template>

<script>
import movielist from "../../components/movie/Card";
import movieswipe from "../../components/home/swipemovie";
export default {
  data() {
    return {};
  },
  components: {
    movielist,
    movieswipe
  },
  methods: {}
};
</script>

<style lang="scss" scoped>
</style>
