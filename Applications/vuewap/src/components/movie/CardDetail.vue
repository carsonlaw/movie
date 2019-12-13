<template>
  <router-link :to="{path: '/movie/'+param.id}" class="linkto">
  <figure>
    <img v-lazy="param.imgsrc" :alt="param.title" />
    <figcaption v-if="param.title">{{param.title}}</figcaption>
  </figure>
  </router-link>
</template>
<script>
export default {
  data() {
    return {};
  },
  props: {
    param: {
      type: Object,
      default: function() {
        return {
          imgsrc: "",
          title: ""
        };
      }
    }
  }
};
</script>
<style scoped>
</style>