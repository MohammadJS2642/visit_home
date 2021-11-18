<template>
    <div>
      <picture>{{ picture }}</picture>
      <div>
        <p>{{ title }}</p>
        <p>{{ price }}</p>
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
  height: 2vh;
}
</style>