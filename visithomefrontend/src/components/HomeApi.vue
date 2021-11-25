<template>
  <!-- container -->
  <div id="home" class="">
    <!-- <div class="row"> -->
    <div class="col-12 col-md-12 mb-4">
      <div class="card h-100">
        <a href="shop-single.html">
          <!-- src="@/assets/img/feature_prod_01.jpg" -->
          <img
            class="card-img-top"
            src="../assets/no_photo.png"
            alt="..."
          />
        </a>
        <div class="card-body">
          <ul class="list-unstyled d-flex justify-content-between">
            <li class="text-muted text-right">تومان {{ price }}</li>
          </ul>
          <a
            href="shop-single.html"
            class="h2 text-decoration-none text-dark"
            >{{ title }}</a
          >
          <p class="card-text"></p>
          <!-- <p class="text-muted">Reviews (24)</p> -->
        </div>
      </div>
    </div>
    <!-- <picture>{{ picture }}</picture>
      <div>
        <p class="col col-xs-4">{{ title }}</p>
        <p class="col col-xs-4">{{ price }}</p>
      </div> -->
    <!-- </div> -->
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  name: "HomeApi",
  data() {
    return {
      homeData: [],
      // tst: require('../'),
    };
  },
  props: ["homeid", "title", "price", "picture"],
  //   setup() {},
});
</script>

<style lang="scss" scoped>
// #home {
//   border: 1px solid black;
// }
</style>