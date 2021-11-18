<template>
  <div class="home">
    <!-- <div v-for="item in jsonData" v-bind:key="item.id">
      <div>
        <h4>{{ item.title }}</h4>
        <p>{{ item.area }}</p>
      </div>
    </div> -->
    <div v-for="item in jsonData" v-bind:key="item.id">
      <router-link :to="{ name: 'HomeIndex', params: { id: item.id } }">
        <HomeApi
          :homeid="item.id"
          v-bind:title="item.title"
          :price="item.price"
        ></HomeApi>
        {{ item.id }}
      </router-link>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
// import HelloWorld from '@/components/HelloWorld.vue'; // @ is an alias to /src
import HomeApi from "../components/HomeApi.vue";

export default defineComponent({
  name: "Home",
  data() {
    return {
      jsonData: [],
    };
  },
  mounted() {
    fetch("https://localhost:5001/api/Home")
      .then((e) => e.json())
      .then((data) => (this.jsonData = data))
      .catch((error) => console.log(error));
  },
  components: {
    // HelloWorld,
    HomeApi,
  },
});
</script>
