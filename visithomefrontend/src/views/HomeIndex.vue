<template>
  <!-- Open Content -->
  <h1 v-if="statusCode == 404">صفحه یافت نشد</h1>
  <section dir="ltr" class="bg-light" v-else>
    <div class="container pb-5">
      <div class="row">
        <div class="col-lg-5 mt-5">
          <div
            class="carousel-inner product-links-wap"
            role="listbox"
            v-if="homeData.pictures == null || homeData.pictures == 0"
          >
            <div class="carousel-item active">
              <div class="row">
                <a href="#">
                  <img
                    src="../assets/no_photo.png"
                    class="card-img img-fluid"
                    alt=""
                  />
                </a>
              </div>
            </div>
          </div>

          <div class="row" v-else>
            <!--Start Controls-->
            <div class="col-1 align-self-center">
              <a href="#multi-item-example" role="button" data-bs-slide="prev">
                <i class="text-dark fas fa-chevron-left"></i>
                <span class="sr-only">قبلی</span>
              </a>
            </div>
            <!--End Controls-->
            <!--Start Carousel Wrapper-->
            <div
              id="multi-item-example"
              class="col-10 carousel slide carousel-multi-item"
              data-bs-ride="carousel"
            >
              <!--Start Slides-->
              <div class="carousel-inner product-links-wap" role="listbox">
                <!--First slide-->
                <div class="carousel-item active">
                  <div class="row">
                    <!-- <div
                      v-if="homeData.pictures == null || homeData.pictures == 0"
                    >
                      <a href="#">
                        <img
                          src="../assets/no_photo.png"
                          class="card-img img-fluid"
                          alt=""
                        />
                      </a>
                    </div> -->
                    <div class="col-4">
                      <a href="#">
                        <img class="card-img img-fluid" alt="Product Image 1" />
                      </a>
                    </div>
                  </div>
                </div>
                <!--/.First slide-->

                <!--Second slide-->
                <div class="carousel-item">
                  <div class="row">
                    <div class="col-4">
                      <a href="#">
                        <img class="card-img img-fluid" alt="Product Image 4" />
                      </a>
                    </div>
                  </div>
                </div>
                <!--/.Second slide-->

                <!--Third slide-->
                <div class="carousel-item">
                  <div class="row">
                    <div class="col-4">
                      <a href="#">
                        <img class="card-img img-fluid" alt="Product Image 7" />
                        <!-- src="../assets/img/product_single_07.jpg" -->
                      </a>
                    </div>
                    <div class="col-4">
                      <a href="#">
                        <img class="card-img img-fluid" alt="Product Image 8" />
                      </a>
                    </div>
                    <div class="col-4">
                      <a href="#">
                        <img class="card-img img-fluid" alt="Product Image 9" />
                      </a>
                    </div>
                  </div>
                </div>
                <!--/.Third slide-->
              </div>
              <!--End Slides-->
            </div>
            <!--End Carousel Wrapper-->
            <!--Start Controls-->
            <div class="col-1 align-self-center">
              <a href="#multi-item-example" role="button" data-bs-slide="next">
                <i class="text-dark fas fa-chevron-right"></i>
                <span class="sr-only">بعدی</span>
              </a>
            </div>
            <!--End Controls-->
          </div>
        </div>
        <!-- col end -->
        <div class="col-lg-7 mt-5">
          <div class="card">
            <div class="card-body">
              <h1 class="h2">{{ homeData.title }}</h1>
              <p class="h3 py-2">
                <span>قیمت : </span>
                <span v-if="homeData.price == '0'">تعیین نشده است</span>
                <span v-else>{{ homeData.price }}</span>
                <span> تومان</span>
              </p>
              <p class="py-2" dir="rtl">
                <!-- <i class="fa fa-star text-warning"></i>
                <i class="fa fa-star text-warning"></i>
                <i class="fa fa-star text-warning"></i>
                <i class="fa fa-star text-warning"></i>
                <i class="fa fa-star text-secondary"></i> -->
                <span
                  >آدرس :
                  <span
                    class="list-inline-item text-dark"
                    v-if="homeData.address == ''"
                  >
                    آدرسی تعیین نگردیده است
                  </span>
                  <span class="list-inline-item text-dark">
                    {{ homeData.address }}
                  </span>
                </span>
              </p>
              <ul class="list-group list-group-flush">
                <li class="list-group-item">
                  <h6>
                    <span>پارکینگ : </span>
                    <span v-if="homeData.parking == 'true'">دارد</span>
                    <span v-else>ندارد</span>
                  </h6>
                </li>
                <li class="list-group-item">
                  <h6>
                    انباری :
                    <span v-if="homeData.warehouse == 'true'">دارد</span>
                    <span v-else>ندارد</span>
                  </h6>
                </li>
              </ul>

              <hr />

              <h6 class="text" dir="rtl">توضیحات :</h6>
              <div>
                {{ homeData.description }}
              </div>
              <!-- <ul class="list-inline">
                <li class="list-inline-item">
                  <h6>Avaliable Color :</h6>
                </li>
                <li class="list-inline-item">
                  <p class="text-muted"><strong>White / Black</strong></p>
                </li>
              </ul>

              <h6>Specification:</h6>
              <ul class="list-unstyled pb-3">
                <li>Lorem ipsum dolor sit</li>
                <li>Amet, consectetur</li>
                <li>Adipiscing elit,set</li>
                <li>Duis aute irure</li>
                <li>Ut enim ad minim</li>
                <li>Dolore magna aliqua</li>
                <li>Excepteur sint</li>
              </ul> -->

              <!-- <form action="" method="GET">
                <input type="hidden" name="product-title" value="Activewear" />
                <div class="row">
                  <div class="col-auto">
                    <ul class="list-inline pb-3">
                      <li class="list-inline-item">
                        Size :
                        <input
                          type="hidden"
                          name="product-size"
                          id="product-size"
                          value="S"
                        />
                      </li>
                      <li class="list-inline-item">
                        <span class="btn btn-success btn-size">S</span>
                      </li>
                      <li class="list-inline-item">
                        <span class="btn btn-success btn-size">M</span>
                      </li>
                      <li class="list-inline-item">
                        <span class="btn btn-success btn-size">L</span>
                      </li>
                      <li class="list-inline-item">
                        <span class="btn btn-success btn-size">XL</span>
                      </li>
                    </ul>
                  </div>
                  <div class="col-auto">
                    <ul class="list-inline pb-3">
                      <li class="list-inline-item text-right">
                        Quantity
                        <input
                          type="hidden"
                          name="product-quanity"
                          id="product-quanity"
                          value="1"
                        />
                      </li>
                      <li class="list-inline-item">
                        <span class="btn btn-success" id="btn-minus">-</span>
                      </li>
                      <li class="list-inline-item">
                        <span class="badge bg-secondary" id="var-value">1</span>
                      </li>
                      <li class="list-inline-item">
                        <span class="btn btn-success" id="btn-plus">+</span>
                      </li>
                    </ul>
                  </div>
                </div>
                <div class="row pb-3">
                  <div class="col d-grid">
                    <button
                      type="submit"
                      class="btn btn-success btn-lg"
                      name="submit"
                      value="buy"
                    >
                      Buy
                    </button>
                  </div>
                  <div class="col d-grid">
                    <button
                      type="submit"
                      class="btn btn-success btn-lg"
                      name="submit"
                      value="addtocard"
                    >
                      Add To Cart
                    </button>
                  </div>
                </div>
              </form> -->

              <br />
              <br />
              <div class="row">
                <a
                  href="/"
                  v-on:click="deleteButton"
                  class="col btn btn-danger ms-2 pe-2 ps-2"
                >
                  حذف
                </a>

                <router-link
                  class="col btn btn-secondary ms-2 pe-2 ps-2"
                  :to="{ path: '/edit/' + homeId }"
                >
                  <!-- :to="{ name: 'EditPage', params: { id: homeId } }" -->
                  <!-- :to="{ name: 'Home' }" -->
                  ویرایش
                </router-link>

                <router-link
                  class="col btn btn-primary ms-4 me-2 pe-5 ps-5"
                  :to="{ name: 'Home' }"
                >
                  بازگشت
                </router-link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- Close Content -->
</template>

<script lang='ts'>
import { defineComponent } from "vue";
import HomeApiVue from "../components/HomeApi.vue";
import axio from "axios";

export default defineComponent({
  name: "HomeIndex",
  mounted() {
    fetch("https://localhost:5001/api/Home/" + this.id)
      .then((e) => e.json())
      .then((data) => {
        this.homeData = data;
        this.homeId = data.id;
        this.statusCode = data.status;
      });
  },
  data() {
    return {
      homeData: [],
      homeId: "",
      statusCode: 0,
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
  methods: {
    async deleteButton(e: any) {
      let result = await axio.delete(
        "https://localhost:5001/api/Home/" + this.homeId
      );
    },
  },
});
</script>

<style lang="scss" scoped>
</style>
