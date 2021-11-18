<template>
  <div id="home" class="container">
    <div class="row">
      <picture>{{ picture }}</picture>
      <div>
        <p class="col col-xs-4">{{ title }}</p>
        <p class="col col-xs-4">{{ price }}</p>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  name: "HomeApi",
  data() {
    return {
      homeData: [],
    };
  },
  props: ["homeid", "title", "price", "picture"],
  //   setup() {},
});
</script>

<style lang="scss" scoped>
#home {
  border: 1px solid black;
}
</style>