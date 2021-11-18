<template>
  <div>
    {{ homeData.title }}
    {{ homeData.price }}
    {{ homeData.address }}
    {{ homeData.parking }}
    {{ homeData.pictures }}
    {{ homeData.floor }}
    {{ homeData.warehouse }}
    {{ homeData.numberOfBedrooms }}
    {{ homeData.area }}
  </div>
</template>

<script lang='ts'>
import { defineComponent } from "vue";

export default defineComponent({
  name: "HomeIndex",
  mounted() {
    fetch("https://localhost:5001/api/Home/" + this.id)
      .then((e) => e.json())
      .then((data) => (this.homeData = data));
  },
  data() {
    return {
      // url_id: this.$route.params.id,
      homeData: [],
    };
  },
  props: ["id"],
  // props: [
  //   "title",
  //   "price",
  //   "address",
  //   "parking",
  //   "pictures",
  //   "floor",
  //   "warehouse",
  //   "numberOfBedrooms",
  //   "area",
  // ],
  // setup() {},
});
</script>

<style lang="scss" scoped>
</style>
